using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public enum Status
    {
        paid, unpaid
    }
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Tour ID")]  //Tách tên hiển thị trên form
        [Required]
        public int TourID { get; set; }

        [Required]
        [Display(Name = "Customer ID")]   //Tách tên hiển thị trên form
        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Bill Date")]
        [Required]
        public DateTime BillDate { get; set; }

        [Required]
        public int DultQuantyti { get; set; }

        [Required]
        public int ChildrenQuantyti { get; set; }


        [Required]
        public Status? Status { get; set; }

        [Display(Name = "Total Price Dult")]
        public decimal TotalPriceDult
        {
            get
            {
                return DultQuantyti * Tour.DultPrice;
            }

        }

        [Display(Name = "Total Price Children")]
        public decimal TotalPriceChildren
        {
            get
            {
                return ChildrenQuantyti * Tour.ChildrenPrice;
            }

        }

        [Display(Name = "Total Price")]
        public decimal TotalPrice
        {
            get
            {
                return TotalPriceChildren + TotalPriceDult;
            }
        }
        public Tour Tour { get; set; }
        public Customer Customer { get; set; }
    }
}
