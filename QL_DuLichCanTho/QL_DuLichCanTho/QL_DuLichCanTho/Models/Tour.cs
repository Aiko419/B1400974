using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantyti { get; set; }

        [Range(1, 1000000000)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal DultPrice { get; set; }

        [Range(1, 1000000000)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal ChildrenPrice { get; set; }

        [StringLength(100)]
        public string Discription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]  // Tên hiển thị trên form
        [Required]
        public DateTime StartDate { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Duration { get; set; }

        [Display(Name = "Tour Total Price")]
        public decimal TourTotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (Bill bill in Bills)
                {

                    total = +bill.TotalPriceChildren + bill.TotalPriceDult;
                }
                return total;
            }
        }

        public ICollection<Bill> Bills { get; set; }
        public ICollection<TourDetail> TourDetails { get; set; }
    }
}
