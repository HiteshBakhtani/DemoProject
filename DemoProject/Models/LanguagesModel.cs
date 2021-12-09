using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class LanguagesModel
    {
        public int ID { get; set; }

        [Required]
        public string Language { get; set; }
    }
}
