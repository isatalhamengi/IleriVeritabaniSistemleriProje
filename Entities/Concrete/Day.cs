using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Day : IEntity
    {
        public int DayID { get; set; }
        public string DayName { get; set; }
    }
}
