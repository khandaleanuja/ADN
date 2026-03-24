using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //System.Collections.ArrayList list = new ArrayList();
            //list.Add(10);


            //Generic collection
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            //num.Add("#"); //error

            //Generic class
            myclass<int> obj1 = new myclass<int>();
            obj1.Data = 20;
            obj1.Show();

        }


    }
    class myclass<T>
    {
        public T Data;
        }
        public void Show()
        {
            Console.WriteLine(Data);
        }
    }

}
