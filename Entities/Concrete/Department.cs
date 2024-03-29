﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        [Key]
        public int D_ID { get; set; }
        public int F_ID { get; set; }
        public string D_NAME { get; set; }
        public string D_DESCRIPTION { get; set; }
        public bool STATUS { get; set; }
    }
}
