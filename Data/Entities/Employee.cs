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
    [Table(name: "Employees", Schema = "empl")]
    public class Employee : BaseEntity
    {
        public AccountentTree AccountentTreeCode { get; set; }
        [MaxLength(40)]
        public string PersonalNumber { get; set; }
        [MaxLength(40)]
        public string Firstname { get; set; }
        [MaxLength(40)]
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(40)]
        public string PhoneNumber { get; set; }
        [MaxLength(40)]
        public string EmailAdress { get; set; }
        public JobPosition JobPosition { get; set; }
    }
}
