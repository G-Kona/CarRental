using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Person
    {
        //Fields
        private string first_name;
        private string last_name;
        private string gender;
        private DateTime date_of_birth;
        private int age;
        private DateTime today = DateTime.Now;
        //Properties
        public string FirstName
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }
        public string LastName
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }
        public string FullName
        {
            get { return this.first_name + " " + this.last_name; }
        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public DateTime DOB
        {
            get { return this.date_of_birth; }
            set { this.date_of_birth = value; }
        }
        public int Age
        {
            get
            {
                if (this.date_of_birth.DayOfYear >= today.DayOfYear)
                {
                    return (today.Year - this.date_of_birth.Year) - 1;
                }
                else
                {
                    return today.Year - this.date_of_birth.Year;
                }
            }
        }
        //Methods
    }
}