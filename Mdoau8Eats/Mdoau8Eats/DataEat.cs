using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mdoau8Eats
{
    [Table("DataEats")]
    public class DataEat
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Proteins { get; set; }
        public float Fats { get; set; }
        public float Carbohy { get; set; }
        public double Kilocalories { get; set; }
    }
}
