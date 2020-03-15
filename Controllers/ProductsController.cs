using System;
using System.Data;
using Core3Sqlite.Models;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core3Sqlite.DataContext;
using Microsoft.Extensions.Options;

namespace Core3Sqlite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly SqliteConnection _db;
        public ProductsController(IOptions<ModelAppSettings> appSettigs)
        {
           _db = new SqliteConnection(appSettigs.Value.ConnectionString);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = new List<Product>();
            _db.Open();
            SqliteCommand cmmd = _db.CreateCommand();
            cmmd.CommandText = "SELECT * FROM Products;";
            cmmd.CommandType = CommandType.Text;
            SqliteDataReader data = cmmd.ExecuteReader();
            while (data.Read())
            {
                Product product = new Product();
                product.Id = Guid.Parse(data.GetString("Id"));
                product.Name = data.GetString("Name");
                product.Price = data.GetInt32("Price");
                products.Add(product);
            }
            return Ok(products);
        }
    }
}