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
    [Table(name: "AccountentTrees", Schema = "acnt")]
    public class AccountentTree : BaseEntity
    {
        [Required]
        [MaxLength(40)]
        public string Code { get; set; }
        [Required]
        [MaxLength(40)]
        public string FullCode { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        public AccountentTree ParentTree { get; set; }
    }
}
