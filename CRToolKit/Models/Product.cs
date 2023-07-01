using System;
namespace CRToolKit.Models
{
	public class Product
	{
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public Boolean IsActive { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Image { get; set; }
        public decimal Height { get; set; }
        public decimal Weidth { get; set; }
        public decimal Breadth { get; set; }
    }
}

