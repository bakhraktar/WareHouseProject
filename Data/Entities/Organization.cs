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
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Adress { get; set; }
        public string GPSAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }
        public OrganizationType OrganizationType { get; set; }
    }
}
