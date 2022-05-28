using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Semester : IEntity
    {
        public int S_ID { get; set; }
        public string S_Name { get; set; }
    }
}
