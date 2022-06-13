using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_HuynhTanHuy.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [StringLength(255)]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }   
    }
}