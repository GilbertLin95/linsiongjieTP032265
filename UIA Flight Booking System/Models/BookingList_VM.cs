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
    
    public partial class BookingList_VM
    {
        public System.Guid BookedByCustomerID { get; set; }
        public System.Guid FlightID { get; set; }
        public System.Guid BookingID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> BookingDateTime { get; set; }
        public string DepartureVenue { get; set; }
        public string DestinationVenue { get; set; }
        public Nullable<System.DateTime> DepartureDateTime { get; set; }
        public Nullable<System.DateTime> ArrivalDateTime { get; set; }
        public Nullable<int> Number_of_Ticket { get; set; }
    }
}
