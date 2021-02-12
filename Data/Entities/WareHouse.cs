using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Base;

namespace Data.Entities
{
    [Table(name: "WareHouses", Schema = "wrhs")]
    public class WareHouse : BaseEntity
    {
        public int Number { get; set; }
        public AccountentTree AccountentTreeCode { get; set; }
        [MaxLength(40)]
        public string Report { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Address { get; set; }
        [MaxLength(40)]
        public Employee Manager { get; set; }
    }
}
