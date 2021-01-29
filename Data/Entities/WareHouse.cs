using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;

namespace Data.Entities
{
    public class WareHouse : BaseEntity
    {
        public int Code { get; set; }
        public string Report { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
