using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Renter : Person
    {
        //Fields
        private string license_number;
        private string province_territory;
        //Properties
        public string LicenceNum
        {
            get { return this.license_number; }
            set { this.license_number = value; }
        }
        public string ProvinceTerr
        {
            get { return this.province_territory; }
            set { this.province_territory = value; }
        }
        //Methods
    }
}