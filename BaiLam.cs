//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_CuoiKy
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaiLam
    {
        public string MaBaiLam { get; set; }
        public string MaHocVien { get; set; }
        public string MaDeThi { get; set; }
        public string MaCauHoi { get; set; }
        public Nullable<float> Diem { get; set; }
    
        public virtual DeThi DeThi { get; set; }
        public virtual HocVien HocVien { get; set; }
    }
}
