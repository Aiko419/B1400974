using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
            set { id = value; }
        }
        [Required(ErrorMessage = "Tiêu đề không được trống")]
        [StringLength(250, ErrorMessage = "Tiêu đề sách không vượt quá 250 ký tự")]
        public string TITLE
        {
            set { title = value; }
            get { return title; }
        }

        public string AUTHOR
        {
            set { author = value; }
            get { return author; }
        }

        public string IMAGE_COVER
        {
            set { image_cover = value; }
            get { return image_cover; }
        }

        


    }
}