﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ClassRoom : IEntity
    {
        [Key]
        public int CR_ID { get; set; }
        public int B_ID { get; set; }
        public int CRT_ID { get; set; }
        public string CR_Name { get; set; }
        public int CR_CAPACITY { get; set; }
        public bool Status { get; set; }
    }
}
