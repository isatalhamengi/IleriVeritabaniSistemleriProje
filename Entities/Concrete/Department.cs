using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public int D_ID { get; set; }
        public int F_ID { get; set; }
        public string D_Name { get; set; }
        public string D_Description { get; set; }
        public bool Status { get; set; }
    }
}
