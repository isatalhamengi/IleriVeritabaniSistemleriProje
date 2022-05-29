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
        public int Total_Student { get; set; }
        public string L_Name { get; set; }
        public DateTime L_Hour { get; set; }
        public bool Status { get; set; }

    }
}
