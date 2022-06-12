using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ClassRoomType : IEntity
    {
        [Key]
        public int CRT_ID { get; set; }
        public string CRT_NAME { get; set; }
    }
}
