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
    
    public partial class HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocVien()
        {
            this.BaiLams = new HashSet<BaiLam>();
        }
    
        public string MaHocVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
        public string MaLopHoc { get; set; }
        public string MaUser { get; set; }
    
        public virtual C_User C_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiLam> BaiLams { get; set; }
        public virtual LopHoc LopHoc { get; set; }
    }
}
