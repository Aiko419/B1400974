//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbo_monhoc
    {
        public string MaMH { get; set; }
        public string MaKhoa { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> SoTC { get; set; }
    
        public virtual dbo_khoa dbo_khoa { get; set; }
    }
}
