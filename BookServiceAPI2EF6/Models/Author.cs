using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookServiceAPI2EF6.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}