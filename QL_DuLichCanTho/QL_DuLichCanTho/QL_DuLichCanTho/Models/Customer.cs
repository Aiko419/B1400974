using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DuLichCanTho.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tài khoản tối thiểu là 3 kí tự, tối đa là 50 kí tự")]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Số điện thoại chỉ được nhập số")]
        [StringLength(15, ErrorMessage = "SDT tối đa 15 kí tự")]
        [Required]
        public string Phone { get; set; }

        [StringLength(100, ErrorMessage = "Địa chỉ tối đa là 100 kí tự")]
        public string Address { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tài khoản tối thiểu là 3 kí tự, tối đa là 50 kí tự")]
        [Required]
        public string UserName { get; set; }

        [StringLength(24, MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu là 3 kí tự, tối đa là 24 kí tự")]
        [Required]
        public string PassWord { get; set; }


        public ICollection<Bill> Bills { get; set; }
    }
}
