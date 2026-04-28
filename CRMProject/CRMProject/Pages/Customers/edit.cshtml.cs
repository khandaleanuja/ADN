using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace CRMProject.Pages.Customers
{
    public class Edit : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; } = "";

        [BindProperty]
        public string Email { get; set; } = "";

        [BindProperty]
        public string Phone { get; set; } = "";

        public void OnGet(int id)
        {
            string connectionString = "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=mysql123;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM customers WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32(0);
                            Name = reader.GetString(1);
                            Email = reader.GetString(2);
                            Phone = reader.GetString(3);
                        }
                    }
                }
            }
        }

        public IActionResult OnPost()
        {
            string connectionString = "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=mysql123;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE customers SET name=@name, email=@email, phone=@phone WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@phone", Phone);

                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToPage("/Customers/Index");
        }
    }
}