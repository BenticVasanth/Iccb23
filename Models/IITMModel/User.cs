//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iitmProject.Models.IITMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public Nullable<int> dob { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public Nullable<int> Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsNotification { get; set; }
    }
}