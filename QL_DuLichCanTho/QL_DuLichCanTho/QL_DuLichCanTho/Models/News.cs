using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Place ID")]
        public int PlaceID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sự kiện tối thiểu là 3")]
        [Required]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sự kiện tối thiểu là 3")] // chưa sữa
        [Required]
        public string Content { get; set; }

        [StringLength(100, ErrorMessage = "đường dẫn tối đa là 100 kí tự")]
        [Required]
        public string Image { get; set; }



        public Place Place { get; set; }
    }
}
