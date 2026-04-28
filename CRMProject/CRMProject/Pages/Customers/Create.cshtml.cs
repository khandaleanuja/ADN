using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;

namespace YourProjectNamespace.Pages.Customers
{
    public class Create : PageModel
    {
        [BindProperty, Required(ErrorMessage = "Enter the name")]
        public string name { get; set; } = "";

        [BindProperty, Required(ErrorMessage = "Enter the email"),
        EmailAddress(ErrorMessage = "Invalid email format")]
        public string email { get; set; } = "";

        [BindProperty, Required(ErrorMessage = "Enter the phone number")]
        public string phone { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                string connectionString = "Server=127.0.0.1;Port=3306;Database=dkte;Uid=root;Pwd=mysql123;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO customers (name, email, phone) VALUES (@name, @email, @phone)";
                    
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phone", phone);

                        command.ExecuteNonQuery();
                    }
                }

                return RedirectToPage("/Customers/Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("", "Error: " + ex.Message);
                return Page();
            }
        }
    }
}