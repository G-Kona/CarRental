using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRental.Models;

namespace CarRental
{
    public partial class index : System.Web.UI.Page
    {
        Renter renter = new Renter();
        int legalAge = 21;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btn_register(object sender, EventArgs e)
        {
            Clear();

            //First Name
            if (Empty(txt_FirstName.Text.Trim()) || NotString(txt_FirstName.Text.Trim()))
            {
                txt_FirstName.Style.Add("background-color", "#a4c5fc");
                txt_FirstName.Style.Add("border", "1px solid red");
                txt_FirstName.Focus();
                err_FirstName.Text = "Invalid input";
                err_FirstName.Style.Add("color", "red");
            }
            //Last Name
            else if (Empty(txt_LastName.Text.Trim()) || NotString(txt_LastName.Text.Trim()))
            {
                txt_LastName.Style.Add("background-color", "#a4c5fc");
                txt_LastName.Style.Add("border", "1px solid red");
                txt_LastName.Focus();
                err_LastName.Text = "Invalid input";
                err_LastName.Style.Add("color", "red");
            }
            //Gender
            else if (rd_Gender.SelectedValue == "" || rd_Gender.SelectedValue == null)
            {
                rd_Gender.Style.Add("background-color", "#a4c5fc");
                rd_Gender.Style.Add("border", "1px solid red");
                rd_Gender.Focus();
                err_Gender.Text = "Please select your gender";
                err_Gender.Style.Add("color", "red");
            }
            //Date of Birth
            else if (date_DOB.Value == "" || date_DOB.Value == null)
            {
                date_DOB.Style.Add("background-color", "#a4c5fc");
                date_DOB.Style.Add("border", "1px solid red");
                date_DOB.Focus();
                err_DOB.Text = "Please select your date of birth";
                err_DOB.Style.Add("color", "red");
            }
            //Legal Age
            else if (!OfLegalAge())
            {
                date_DOB.Style.Add("background-color", "#a4c5fc");
                date_DOB.Style.Add("border", "1px solid red");
                date_DOB.Focus();
                err_DOB.Text = "You must be at least 21 years of age to rent a car";
                err_DOB.Style.Add("color", "red");
            }
            //License Number
            else if (txt_LicenseNum.Text.Trim().Length != 10)
            {
                txt_LicenseNum.Style.Add("background-color", "#a4c5fc");
                txt_LicenseNum.Style.Add("border", "1px solid red");
                txt_LicenseNum.Focus();
                err_LicenseNum.Text = "License number must be 10 characters long";
                err_LicenseNum.Style.Add("color", "red");
            }
            //Province Territory
            else if (slct_ProvTerr.SelectedIndex == 0 || slct_ProvTerr.SelectedIndex == 1 || slct_ProvTerr.SelectedIndex == 10)
            {
                slct_ProvTerr.Style.Add("background-color", "#a4c5fc");
                slct_ProvTerr.Style.Add("border", "1px solid red");
                slct_ProvTerr.Focus();
                err_ProvinceTerr.Text = "Invalid selection";
                err_ProvinceTerr.Style.Add("color", "red");
            }
            //Display registration info
            else
            {
                Display();
            }
        }

        public void Display()
        {
            //Declarations
            renter.FirstName = txt_FirstName.Text.Trim();
            renter.LastName = txt_LastName.Text.Trim();
            renter.Gender = rd_Gender.SelectedValue;
            renter.LicenceNum = txt_LicenseNum.Text.Trim();
            renter.ProvinceTerr = slct_ProvTerr.Value.ToString();

            //Output
            out_Renter.Text = "Renter:";
            out_Renter.Style.Add("text-decoration", "underline");
            out_Renter.Style.Add("font-weight", "bold");
            out_Name.Text = "Name: " + "<strong>" + renter.FullName + "</strong>";
            out_Gender.Text = "Gender: " + "<strong>" + renter.Gender + "</strong>";
            out_DOB.Text = "Date of birth: " + "<strong>" + renter.DOB.ToLongDateString() + "</strong>";
            out_Age.Text = "Age: " + "<strong>" + renter.Age.ToString() + "</strong>";
            out_LicenseNum.Text = "License Number: " + "<strong>" + renter.LicenceNum + "</strong>";
            out_ProvinceTerr.Text = "Province/Territory: " + "<strong>" + renter.ProvinceTerr + "</strong>";
        }

        public bool Empty(string input)
        {
            if (input == "" || input == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NotString(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OfLegalAge()
        {
            renter.DOB = Convert.ToDateTime(date_DOB.Value);

            if (renter.Age < legalAge)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clear()
        {
            //Clear Error Lables
            err_FirstName.Text = "";
            err_LastName.Text = "";
            err_Gender.Text = "";
            err_DOB.Text = "";
            err_LicenseNum.Text = "";
            err_ProvinceTerr.Text = "";

            //Clear Error Styling
            txt_FirstName.Style.Clear();
            txt_LastName.Style.Clear();
            rd_Gender.Style.Clear();
            date_DOB.Style.Clear();
            txt_LicenseNum.Style.Clear();
            slct_ProvTerr.Style.Clear();
        }
    }
}