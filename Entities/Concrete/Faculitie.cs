using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Faculitie : IEntity
    {
        [Key]
        public int F_ID { get; set; }
        public string F_NAME { get; set; }
        public string F_DESCRIPTION { get; set; }
        public bool STATUS { get; set; }
    }
}
