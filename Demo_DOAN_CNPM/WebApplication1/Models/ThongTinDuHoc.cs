//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinDuHoc
    {
        public int MaTTDH { get; set; }
        public string TenThongTinDuHoc { get; set; }
        public string TenTruong { get; set; }
        public string DiaChiTruong { get; set; }
        public string MoTaThongTin { get; set; }
        public string ChiPhi { get; set; }
        public string HocLuc { get; set; }
        public string TiengAnh { get; set; }
        public System.DateTime NgayDang { get; set; }
        public System.DateTime HanNop { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
        public string MaBacHoc { get; set; }
        public string MaBang { get; set; }
    
        public virtual BacHoc BacHoc { get; set; }
        public virtual DiaChiBang DiaChiBang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
