//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIA_Flight_Booking_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pricing
    {
        public System.Guid PriceID { get; set; }
        public System.Guid FlightID { get; set; }
        public string AgeCategory { get; set; }
        public string ClassCategory { get; set; }
        public decimal Price { get; set; }
    
        public virtual Flight_Detail Flight_Detail { get; set; }
    }
}
