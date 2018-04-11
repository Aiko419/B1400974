using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public class Place
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên tối thiểu là 3 tối đa là 50 kí tự")]
        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string Discripton { get; set; }

        [StringLength(100, ErrorMessage = "đường dẫn tối đa là 100 kí tự")]
        [Required]
        public string Image { get; set; }

        public ICollection<TourDetail> TourDetails { get; set; }
        public ICollection<News> Newss { get; set; }
    }
}
