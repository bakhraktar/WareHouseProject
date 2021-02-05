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
        public string Report { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
