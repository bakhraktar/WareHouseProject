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
    [Table(name: "Manufacturers", Schema = "mnfc")]
    public class Manufacturer : BaseEntity
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}
