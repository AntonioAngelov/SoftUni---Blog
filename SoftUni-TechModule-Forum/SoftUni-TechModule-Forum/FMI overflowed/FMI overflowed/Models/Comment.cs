using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMI_overflowed.Models
{
    public class Comment
    {   [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        
        public Post Post { get; set; }
    }
}