﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Base;

namespace Data.Entities
{
    [Table(name: "JobPositions", Schema = "jbps")]
    public class JobPosition : BaseEntity
    {
        public string Position { get; set; }
    }
}
