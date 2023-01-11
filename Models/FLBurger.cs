﻿using SQLite;

namespace FLAppBurger.Models
{
    [Table("burger")]
    public class FLBurger
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool WithExtraCheese { get; set; }
    }
}
