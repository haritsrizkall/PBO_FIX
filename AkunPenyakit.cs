//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UASPBO
{
    using System;
    using System.Collections.Generic;
    
    public partial class AkunPenyakit
    {
        public int Id { get; set; }
        public Nullable<int> IdPenyakit { get; set; }
        public Nullable<int> IdAkun { get; set; }
        public string LamaSakit { get; set; }
        public string DeskripsiKeluhan { get; set; }
        public string JadwalKonsul { get; set; }
    
        public virtual Akun Akun { get; set; }
        public virtual Penyakit Penyakit { get; set; }
    }
}
