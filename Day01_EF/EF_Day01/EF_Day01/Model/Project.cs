using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day01.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(500000, 3500000)]
        public decimal Cost { get; set; }
    }

}
