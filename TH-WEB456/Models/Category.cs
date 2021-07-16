using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TH_WEB456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

    }
}