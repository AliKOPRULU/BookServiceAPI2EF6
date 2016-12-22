using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookServiceAPI2EF6.Models
{
    public class BookDTO//data transfer object
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
    }
}