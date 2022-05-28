using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Building : IEntity
    {
        public int B_ID { get; set; }
        public string B_Name{ get; set; }
        public string B_Description { get; set; }
        public bool Status { get; set; }
    }
}
