//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThiThu.Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbo_khoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbo_khoa()
        {
            this.dbo_monhoc = new HashSet<dbo_monhoc>();
            this.dbo_nganh = new HashSet<dbo_nganh>();
        }
    
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Nullable<System.DateTime> NgayTL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbo_monhoc> dbo_monhoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbo_nganh> dbo_nganh { get; set; }
    }
}
