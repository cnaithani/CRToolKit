using System;
namespace CRToolKit.Models
{
	public class Product
	{
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Image { get; set; }
    }
}

