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
    
    public partial class HoSoDuHoc
    {
        public int MaHoSo { get; set; }
        public Nullable<double> HocLuc { get; set; }
        public string TiengAnh { get; set; }
        public System.DateTime NgayNop { get; set; }
        public string TrangThai { get; set; }
        public string MaBacHoc { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
    
        public virtual BacHoc BacHoc { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
