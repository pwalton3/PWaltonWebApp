<%@ Page Title="SimpleQuery" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="WebApp.SamplePages.SimpleQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Simple Query</h1>
    <blockquote class="alert alert-info">
        This page will input a Region number and display the region record matching that input value.
    </blockquote>
    <div class="row">
        <div class="col-6">
            <asp:Label ID="Label1" runat="server" Text="Enter Region ID"></asp:Label>
            <asp:TextBox ID="RegionArg" runat="server"></asp:TextBox>
            <asp:Button ID="RegionSearch" runat="server" Text="Region ?" OnClick="RegionSearch_Click" />
        </div>
        <div class="col-6">
            <asp:Label ID="Label2" runat="server" Text="RegionID: "></asp:Label>
            <asp:Label ID="RegionID" runat="server" ></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Description: "></asp:Label>
            <asp:Label ID="RegionDescription" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div  class="row">
        <div class="col-12 text-center">
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
