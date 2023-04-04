using iitmProject.Models.IITMModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iitmProject.Models
{
    public class ReguserModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required")]  
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        public int Mobile { get; set; }

        [Required(ErrorMessage = "Organisation is required")]
        public string Org { get; set; }

        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Pincode is required")]
        public int Pincode { get; set; }

        public virtual List<ReguserModel> ReguserModel1 { get; set; }
        public ReguserModel()
        {
            this.ReguserModel1 = new List<ReguserModel>();
        }

        public ReguserModel(UserTest use)
        {
            id = use.id;
            Name = use.Name;
            Email = use.Email;
            Mobile = use.Mobile;
            Org = use.Org;
            Position = use.Position;
            Address = use.Address;
            State = use.State;
            Country = use.Country;
            Pincode = use.Pincode;
         }

        public ReguserModel ConvertFromRole(UserTest use)
        {
            id = use.id;
            Name = use.Name;
            Email = use.Email;
            Mobile = use.Mobile;
            Org = use.Org;
            Position = use.Position;
            Address = use.Address;
            State = use.State;
            Country = use.Country;
            Pincode = use.Pincode;
            return this;
        }
    }
}
