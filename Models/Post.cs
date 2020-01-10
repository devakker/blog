using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime LastEdited { get; set; }
        public string Preview { get; set; }
        public string Body { get; set; }
    }
}
