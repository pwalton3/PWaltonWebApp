<%@ Page Title="Common Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommonControls.aspx.cs" Inherits="BasicWebASP2.SamplePages.CommonControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Common Web Form Controls using event driven logic</h1>
    <%-- text box --%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label1" runat="server" Text="Enter a selection choice 1 to 4:"></asp:Label>&nbsp;
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="NumberChoice" Width="50px" height="30px" ToolTip="Enter a number  between 1 and 4" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:Button ID="SubmitNumberChoice" runat="server" Text="Submit Number Choice" CssClass="btn btn-success" OnClick="SubmitNumberChoice_Click" />

        </div>
    </div>
    <%-- Radio button  --%>

     <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label2" runat="server" Text="Radio Buttons of choice:"></asp:Label>&nbsp;
        </div>
         
        <div class="col-md-6">
            <asp:RadioButtonList ID="RadioButtonListChoice" runat="server">
                <asp:ListItem Value="1">COMP1008</asp:ListItem>
                <asp:ListItem Value="2">CPSC1517</asp:ListItem>
                <asp:ListItem Value="3">DMIT1508</asp:ListItem>
                <asp:ListItem Value="4">DMIT2018</asp:ListItem>
            </asp:RadioButtonList>

        </div>
    </div>
    <%-- CHECK BOX --%>
         <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label3" runat="server" Text="Checkbox of choice:"></asp:Label>&nbsp;
        </div>
         
        <div class="col-md-6 text-left">
            <asp:CheckBox ID="CheckBoxChoice" runat="server" Text=" (checked if a programming language)" />
         </div>
        </div>

    <%-- Literal/Label --%>
        <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label4" runat="server" Text="Radio Buttons of choice:"></asp:Label>&nbsp;
        </div>
         
        <div class="col-6">
            <asp:Label ID="DisplayReadOnly" runat="server"> </asp:Label>
        </div>
             </div>
    <%-- DropDownList --%>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Label ID="Label5" runat="server" Text="DDL collection:"></asp:Label>&nbsp;
        </div>
         
        <div class="col-md-6">
            <asp:DropDownList ID="CollectionList" runat="server" />&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButtonChoice" runat="server" OnClick="LinkButtonChoice_Click">Submit Collection Choice</asp:LinkButton>

         </div>
        </div>
    <%-- output area for messages --%>
     <div class="row">
        <div class="col-12 text-center">
            <asp:Label ID="Messagelabel" runat="server" ></asp:Label>&nbsp;
        </div>
     </div>
</asp:Content>
