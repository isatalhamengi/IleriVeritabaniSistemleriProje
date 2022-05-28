using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Faculitie : IEntity
    {
        public int F_ID { get; set; }
        public string F_Name { get; set; }
        public string F_Description { get; set; }
        public bool Status { get; set; }
    }
}
