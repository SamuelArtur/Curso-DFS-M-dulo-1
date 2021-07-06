using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
    }
}
