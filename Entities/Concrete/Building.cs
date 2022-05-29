using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Building : IEntity
    {
        [Key]
        public int B_ID { get; set; }
        public string B_NAME { get; set; }
        public string B_DESCRPITION { get; set; }
        public bool STATUS { get; set; }
    }
}
