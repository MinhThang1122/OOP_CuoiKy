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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauHoi()
        {
            this.DeThis = new HashSet<DeThi>();
        }
    
        public string MaCauHoi { get; set; }
        public Nullable<int> DapAn { get; set; }
        public byte[] HinhAnhCauHoi { get; set; }
        public string MaChuong { get; set; }
        public string MaMonHoc { get; set; }
    
        public virtual Chuong Chuong { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeThi> DeThis { get; set; }
    }
}
