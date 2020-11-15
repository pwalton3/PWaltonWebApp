<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="BasicWebASP2.HelloWorld" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World</h1>
    <div class="row">
        <div class="offset-1">
            <asp:Label ID="PromptLabel" runat="server" Text="Enter Your Name"></asp:Label>
            <asp:TextBox ID="NameArg" runat="server" ToolTip="Enter your name" placeholder="your name"></asp:TextBox>
            <asp:Button ID="PressMe" CssClass="btn btn-primary" runat="server" Text="Press Me" OnClick="PressMe_Click" /><br /> 
            <asp:Label ID="OutputArea" runat="server" Text="Output Area"></asp:Label>
        </div>
    </div>
</asp:Content>
