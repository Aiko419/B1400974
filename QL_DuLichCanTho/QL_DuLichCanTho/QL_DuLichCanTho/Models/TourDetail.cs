using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public class TourDetail : DbContext
    {
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tour ID")]  //Tách tên hiển thị trên form
        public int TourID { get; set; }

        [Key, Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Place ID")]  //Tách tên hiển thị trên form
        public int PlaceID { get; set; }

        [Required]
        [Display(Name = "Number Tour")]  //Number Tour: số thứ tự tour
        public int NumberTour { get; set; }


        public Tour Tour { get; set; }
        public Place Place { get; set; }
    }
}
