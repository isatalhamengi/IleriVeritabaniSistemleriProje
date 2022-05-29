using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Semester : IEntity
    {
        [Key]
        public int S_ID { get; set; }
        public string S_Name { get; set; }
    }
}
