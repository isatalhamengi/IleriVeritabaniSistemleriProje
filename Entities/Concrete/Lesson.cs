using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson : IEntity
    {
        [Key]
        public int L_ID { get; set; }
        public int D_ID { get; set; }
        public int S_ID { get; set; }
        public int T_ID { get; set; }
        public int TOTAL_STUDENT { get; set; }
        public string L_NAME { get; set; }
        public DateTime L_HOUR { get; set; }
        public bool STATUS { get; set; }

    }
}
