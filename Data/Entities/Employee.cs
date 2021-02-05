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
        public string PersonalNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public JobPosition JobPosition { get; set; }
    }
}
