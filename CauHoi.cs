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
    
    public partial class CauHoi
    {
        public string MaCauHoi { get; set; }
        public byte[] HinhAnhCauHoi { get; set; }
        public string MaChuong { get; set; }
        public string MaMonHoc { get; set; }
        public Nullable<int> DapAn { get; set; }
    
        public virtual Chuong Chuong { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}
