//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCsharpFSWF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public int MeydancaId { get; set; }
        public int OtaqId { get; set; }
        public int MushteriId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public decimal Price { get; set; }
    
        public virtual Meydancalar Meydancalar { get; set; }
        public virtual Mushteri Mushteri { get; set; }
        public virtual Otaqlar Otaqlar { get; set; }
    }
}
