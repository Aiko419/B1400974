using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class StaffModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}
