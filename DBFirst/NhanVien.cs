//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public string idnhanvien { get; set; }
        public string tennhanvien { get; set; }
        public Nullable<int> tuoi { get; set; }
        public string idphongban { get; set; }
    
        public virtual phongban phongban { get; set; }
    }
}