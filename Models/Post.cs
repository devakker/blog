using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Last Edited")]
        public DateTime LastEdited { get; set; }

        public string Preview { get; set; }
        public string Body { get; set; }
    }
}
