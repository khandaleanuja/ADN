//using System;

//namespace SOLID_Student_Example
//{
//    // ===============================
//    // S - Single Responsibility Principle
//    // ===============================
//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Course { get; set; }
//    }

//    class StudentPrinter
//    {
//        public void Print(Student student)
//        {
//            Console.WriteLine("Student ID   : " + student.Id);
//            Console.WriteLine("Student Name : " + student.Name);
//            Console.WriteLine("Course       : " + student.Course);
//        }
//    }

//    // ===============================
//    // O - Open/Closed Principle
//    // ===============================
//    abstract class GradeCalculator
//    {
//        public abstract string CalculateGrade(int marks);
//    }

//    class PercentageGrade : GradeCalculator
//    {
//        public override string CalculateGrade(int marks)
//        {
//            if (marks >= 75) return "A";
//            if (marks >= 60) return "B";
//            return "C";
//        }
//    }

//    // ===============================
//    // L - Liskov Substitution Principle
//    // ===============================
//    class StudentBase
//    {
//        public virtual void Study()
//        {
//            Console.WriteLine("Student is studying");
//        }
//    }

//    class CollegeStudent : StudentBase
//    {
//        public override void Study()
//        {
//            Console.WriteLine("College student is studying");
//        }
//    }

//    // ===============================
//    // I - Interface Segregation Principle
//    // ===============================
//    interface ICourse
//    {
//        void EnrollCourse();
//    }

//    interface IExam
//    {
//        void GiveExam();
//    }

//    class OnlineStudent : ICourse, IExam
//    {
//        public void EnrollCourse()
//        {
//            Console.WriteLine("Student enrolled in online course");
//        }

//        public void GiveExam()
//        {
//            Console.WriteLine("Student giving online exam");
//        }
//    }

//    // ===============================
//    // D - Dependency Inversion Principle
//    // ===============================
//    interface INotificationService
//    {
//        void Send(string message);
//    }

//    class EmailNotification : INotificationService
//    {
//        public void Send(string message)
//        {
//            Console.WriteLine("Email sent to student: " + message);
//        }
//    }

//    class StudentNotification
//    {
//        private INotificationService notificationService;

//        public StudentNotification(INotificationService service)
//        {
//            notificationService = service;
//        }

//        public void Notify(string message)
//        {
//            notificationService.Send(message);
//        }
//    }

//    // ===============================
//    // MAIN METHOD
//    // ===============================
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // SRP
//            Student student = new Student
//            {
//                Id = 1,
//                Name = "Anuja",
//                Course = "Computer Science"
//            };

//            StudentPrinter printer = new StudentPrinter();
//            printer.Print(student);

//            Console.WriteLine();

//            // OCP
//            GradeCalculator gradeCalculator = new PercentageGrade();
//            Console.WriteLine("Grade: " + gradeCalculator.CalculateGrade(78));

//            Console.WriteLine();

//            // LSP
//            StudentBase s = new CollegeStudent();
//            s.Study();

//            Console.WriteLine();

//            // ISP
//            OnlineStudent onlineStudent = new OnlineStudent();
//            onlineStudent.EnrollCourse();
//            onlineStudent.GiveExam();

//            Console.WriteLine();

//            // DIP
//            INotificationService emailService = new EmailNotification();
//            StudentNotification notification = new StudentNotification(emailService);
//            notification.Notify("Your course has been updated");

//            Console.ReadLine();
//        }
//    }
//}




using System;

namespace SOLID_Student_Example
{
    // ===============================
    // S - Single Responsibility Principle
    // ===============================
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }

    class StudentPrinter
    {
        public void Print(Student student)
        {
            Console.WriteLine("Student ID   : " + student.Id);
            Console.WriteLine("Student Name : " + student.Name);
            Console.WriteLine("Course       : " + student.Course);
        }
    }

    // ===============================
    // O - Open/Closed Principle (WITH EXCEPTION)
    // ===============================
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }

    abstract class GradeCalculator
    {
        public abstract string CalculateGrade(int marks);
    }

    class PercentageGrade : GradeCalculator
    {
        public override string CalculateGrade(int marks)
        {
            if (marks < 0 || marks > 100)
                throw new InvalidMarksException("Marks must be between 0 and 100");

            if (marks >= 75) return "A";
            if (marks >= 60) return "B";
            return "C";
        }
    }

    // ===============================
    // L - Liskov Substitution Principle (WITH EXCEPTION)
    // ===============================

    class StudyNotAllowedException : Exception
    {
        public StudyNotAllowedException(string message) : base(message) { }
    }

    class StudentBase
    {
        public virtual void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }

    class CollegeStudent : StudentBase
    {
        public override void Study()
        {
            Console.WriteLine("College student is studying");
        }
    }

    // This class violates LSP by throwing exception
    class SuspendedStudent : StudentBase
    {
        public override void Study()
        {
            throw new StudyNotAllowedException("Suspended student is not allowed to study");
        }
    }

    // ===============================
    // I - Interface Segregation Principle
    // ===============================
    interface ICourse
    {
        void EnrollCourse();
    }

    interface IExam
    {
        void GiveExam();
    }

    class OnlineStudent : ICourse, IExam
    {
        public void EnrollCourse()
        {
            Console.WriteLine("Student enrolled in online course");
        }

        public void GiveExam()
        {
            Console.WriteLine("Student giving online exam");
        }
    }

    // ===============================
    // D - Dependency Inversion Principle
    // ===============================
    interface INotificationService
    {
        void Send(string message);
    }

    class EmailNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent to student: " + message);
        }
    }

    class StudentNotification
    {
        private INotificationService notificationService;

        public StudentNotification(INotificationService service)
        {
            notificationService = service;
        }

        public void Notify(string message)
        {
            notificationService.Send(message);
        }
    }

    // ===============================
    // MAIN METHOD
    // ===============================
    class Program
    {
        static void Main(string[] args)
        {
            // SRP
            Student student = new Student
            {
                Id = 1,
                Name = "Anuja",
                Course = "Computer Science"
            };

            StudentPrinter printer = new StudentPrinter();
            printer.Print(student);

            Console.WriteLine();

            // OCP WITH EXCEPTION
            try
            {
                GradeCalculator gradeCalculator = new PercentageGrade();
                Console.WriteLine("Grade: " + gradeCalculator.CalculateGrade(120));
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // LSP WITH EXCEPTION
            try
            {
                StudentBase s1 = new CollegeStudent();
                s1.Study();

                StudentBase s2 = new SuspendedStudent();
                s2.Study(); // Will throw exception
            }
            catch (StudyNotAllowedException ex)
            {
                Console.WriteLine("LSP Exception: " + ex.Message);
            }

            Console.WriteLine();

            // ISP
            OnlineStudent onlineStudent = new OnlineStudent();
            onlineStudent.EnrollCourse();
            onlineStudent.GiveExam();

            Console.WriteLine();

            // DIP
            INotificationService emailService = new EmailNotification();
            StudentNotification notification = new StudentNotification(emailService);
            notification.Notify("Your course has been updated");

            Console.ReadLine();
        }
    }
}

