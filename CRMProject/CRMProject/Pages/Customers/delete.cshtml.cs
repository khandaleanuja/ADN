using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace CRMProject.Pages.Customers
{
    public class Delete : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        public void OnGet(int id)
        {
            Id = id;
        }

        public IActionResult OnPost()
        {
            string connectionString = "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=mysql123;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM customers WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToPage("/Customers/Index");
        }
    }
}