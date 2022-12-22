﻿using SQLite;
namespace Simion_Roxana_Lab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
