using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LessonDetail : IEntity
    {
        public int LD_ID { get; set; }
        public int LD_LID { get; set; }
        public int LD_DAYID { get; set; }
        public DateTime LD_STARTHOUR { get; set; }
        public DateTime LD_ENDHOUR { get; set; }
    }
}
