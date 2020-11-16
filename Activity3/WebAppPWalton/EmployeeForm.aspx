<%@ Page Title="Employee Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="WebAppPWalton.EmployeeForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Employee - Activity 2 Assessment</h1>
    <blockquote class="alert alert-info text-center">THis assessment will test basic web form construction, validation, data collection and display.</blockquote>

    <asp:RequiredFieldValidator ID="RequiredName" runat="server" ErrorMessage="Name is required" ControlToValidate="EmpName" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

    <asp:CompareValidator ID="RequiredEmployeeID" runat="server" ErrorMessage="Employee ID is a required field and must be a integer greater than 0" SetFocusOnError="true" ControlToValidate="EmployeeID" Display="None" Type="Integer"  ></asp:CompareValidator>

    <asp:CompareValidator ID="RequiredVacaDays" runat="server" ErrorMessage="Vacation days is a required field and must be greater than 0" SetFocusOnError="true" ControlToValidate="VacaDays" Display="None" Type="Integer"></asp:CompareValidator>


    <div class="row">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" HeaderText="Employee Data Entry Errors:" />
    <div class="col-6">
        <h3>Employee Data Entry</h3>
        <div class="offset-2">
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
            <asp:Label ID="EmployeeID" runat="server" Text="Employee ID"></asp:Label>
            <asp:TextBox ID="ForEmployeeID" runat="server"></asp:TextBox> <br /><br />

            <asp:Label ID="EmpName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="ForName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="VacaDays" runat="server" Text="Vacation Days"></asp:Label>
            <asp:TextBox ID="ForVacaDays" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="EmergNum" runat="server" Text="Emergency Phone Number"></asp:Label>
            <asp:TextBox ID="ForEmergNum" runat="server"></asp:TextBox><br /><br />
        </div>
        <asp:Button ID="submit" runat="server" Text="Add Employee" OnClick="submit_Click" />
        <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />
    </div>
</div>
 


</asp:Content>
