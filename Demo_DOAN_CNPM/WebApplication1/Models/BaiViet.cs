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
    
    public partial class BaiViet
    {
        public int MaBaiViet { get; set; }
        public string TenBaiViet { get; set; }
        public string AnhBaiViet { get; set; }
        public string NoiDung { get; set; }
        public System.DateTime ThoiGian { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}