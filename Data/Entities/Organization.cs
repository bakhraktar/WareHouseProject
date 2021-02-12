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
    [Table(name: "Organizations", Schema = "orgn")]
    public class Organization : BaseEntity
    {
        public AccountentTree AccountentTreeCode { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string EnglishName { get; set; }
        [MaxLength(40)]
        public string City { get; set; }
        [MaxLength(40)]
        public string Region { get; set; }
        [MaxLength(40)]
        public string PostalCode { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string GPSAddress { get; set; }
        [MaxLength(40)]
        public string PhoneNumber { get; set; }
        [MaxLength(40)]
        public string EmailAddress { get; set; }
        [MaxLength(40)]
        public string WebSite { get; set; }
        public OrganizationType OrganizationType { get; set; }
    }
}
