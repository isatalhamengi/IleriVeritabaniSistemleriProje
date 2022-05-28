using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hour : IEntity
    {
        public int HourID { get; set; }
        public DateTime HourName { get; set; }
    }
}
