using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace CRMProject.Pages.Customers
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }

        // Model
        public class CustomerInfo
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Email { get; set; } = "";
            public string Phone { get; set; } = "";
        }

        // List
        public List<CustomerInfo> listCustomers { get; set; } = new List<CustomerInfo>();

        // GET Method
        public void OnGet()
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=mysql123;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM customers";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CustomerInfo customer = new CustomerInfo
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.GetString(3)
                                };

                                listCustomers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error retrieving customers: " + ex.Message);
            }
        }
    }
}