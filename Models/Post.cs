using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace blog.Models
{
    public class Post
    {
        [Required]
        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }


        [Display(Name = "Last Edited")]
        [DataType(DataType.DateTime)]
        public DateTime LastEdited { get; set; }

        [Required]
        [StringLength(400)]
        public string Preview { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}
