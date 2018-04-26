using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucHanh3.Areas.Admin.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Year { get; set; }
        public string CoverPage { get; set; }
    }
}