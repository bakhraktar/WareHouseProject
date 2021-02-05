using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Base;

namespace Data.Entities
{
    [Table(name: "Currencies", Schema = "crcy")]
    public class Currency : BaseEntity
    {
        public MoneyUnit FirstMoneyUnit { get; set; }
        public int Course { get; set; }
        public MoneyUnit SecondMoneyUnit { get; set; }
    }
}
