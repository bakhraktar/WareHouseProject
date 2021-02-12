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
        [MaxLength(40)]
        public string InitialCode { get; set; }
        public AccountentTree AccountentTreeCode { get; set; }
        [MaxLength(40)]
        public string Barcode { get; set; }
        [MaxLength(40)]
        public string BoxCode { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string EnglishName { get; set; }
        public MoneyUnit MoneyUnit { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductType ProcutType { get; set; }
        public Color Color { get; set; }
        public Origin Origin { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Brand Brand { get; set; }
        [MaxLength(40)]
        public string Photo { get; set; }
        public double SelfCost { get; set; }
        public double Price { get; set; }
    }
}
