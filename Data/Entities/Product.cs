using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;

namespace Data.Entities
{
    public class Product : BaseEntity
    {
        public string InternalReport { get; set; }
        public string BoxCode { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public int MyProperty { get; set; }
    }
}
