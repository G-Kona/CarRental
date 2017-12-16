<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CarRental.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Car Rental</h1>
    <h2>Register for a rental car</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_FirstName" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txt_FirstName" runat="server"></asp:TextBox>
            <asp:Label ID="err_FirstName" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_LastName" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="txt_LastName" runat="server"></asp:TextBox>
            <asp:Label ID="err_LastName" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Gender" runat="server" Text="Gender:"></asp:Label>
            <asp:Label ID="err_Gender" runat="server"></asp:Label>
            <asp:RadioButtonlist ID="rd_Gender" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
                <asp:ListItem Text="Other"></asp:ListItem>
            </asp:RadioButtonlist>
            <br />
            <asp:Label ID="lbl_DOB" runat="server" Text="Date of birth:"></asp:Label>
            <input type="date" ID="date_DOB" runat="server"/>
            <asp:Label ID="err_DOB" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_LicenseNum" runat="server" Text="Driver's License: "></asp:Label>
            <asp:TextBox ID="txt_LicenseNum" runat="server"></asp:TextBox>
            <asp:Label ID="err_LicenseNum" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_ProvinceTerr" runat="server" Text="Province/Territory:"></asp:Label>
            <select ID="slct_ProvTerr" runat="server">
                <option runat="server">- - -</option>
                <option runat="server">- Provinces -</option>
                <option runat="server">Alberta</option>
                <option runat="server">British Columbia</option>
                <option runat="server">Manitoba</option>
                <option runat="server">New Brunswick</option>
                <option runat="server">Newfoundland and Labrador</option>
                <option runat="server">Nova Scotia</option>
                <option runat="server">Ontario</option>
                <option runat="server">Saskatchewan</option>
                <option runat="server">- Territories -</option>
                <option runat="server">Yukon</option>
                <option runat="server">Nunavut</option>
                <option runat="server">Northwest Territories</option>
            </select>
            <asp:Label ID="err_ProvinceTerr" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_submit" runat="server" Text="SUBMIT!" OnClick="btn_register" />
            <br />
            <br />
            <asp:Label ID="out_Renter" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_Name" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_Gender" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_DOB" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_Age" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_LicenseNum" runat="server"></asp:Label>
            <br />
            <asp:Label ID="out_ProvinceTerr" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
