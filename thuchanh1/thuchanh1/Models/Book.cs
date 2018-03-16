using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thuchanh1.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;

        public Book()
        {

        }

        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }

        public int ID
        {
            get { return id; }
        }

        public string TITLE
        {
            get { return title; }
        }

        public string AUTHOR
        {
            get { return author; }
        }

        public string IMAGE_COVER
        {
            get { return image_cover; }
        }

    }
}