﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet5Docker.Models;
using Microsoft.AspNet.Mvc;
using Npgsql;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNet5Docker.Controllers
{
    public class LocationController : Controller
    {

        private const string connStr = "Host=192.168.1.7;Username=postgres;Password=mysecretpassword;Database=coffee";

        public IActionResult Index()
        {
            var locations = new List<Location>();
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT name FROM Locations";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locations.Add(new Location() { Name = reader.GetString(0) });
                        }
                    }
                }
            }


            return View(locations);
        }

        public IActionResult Add(string newLocation)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Locations (id, name) VALUES (1, '" + newLocation + "')";
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
    }
}
