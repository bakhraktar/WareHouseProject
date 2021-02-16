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
        public string Code { get; set; }
        public string FullCode { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual IEnumerable<AccountentTree> ChildrenTree { get; set; }
    }
}
