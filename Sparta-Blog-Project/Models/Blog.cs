using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparta_Blog_Project.Models
{
    public class Blog
    {   [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required, StringLength(50)]
        public string Author { get; set; }

        [Required]
        public string Content { get; set; }
    }
}