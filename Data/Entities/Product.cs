using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Base;

namespace Data.Entities
{
    [Table(name: "Products", Schema = "prdc")]
    public class Product : BaseEntity
    {
        public int InitialCode { get; set; }
        public string Report { get; set; }
        public string Barcode { get; set; }
        public string BoxCode { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public MoneyUnit MoneyUnit { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductType ProcutType { get; set; }
        public Color Color { get; set; }
        public Origin Origin { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Brand Brand { get; set; }
        public string Proto { get; set; }
        public double SelfCost { get; set; }
        public double Price { get; set; }
    }
}
