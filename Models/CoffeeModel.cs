﻿using SQLite;

namespace MyCoffeeMVVMSQLite.Models
{
    public class CoffeeModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Roaster { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
