﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        [Key]
        public int T_ID { get; set; }
        public string T_NAME { get; set; }
        public string T_SURNAME { get; set; }
    }
}
