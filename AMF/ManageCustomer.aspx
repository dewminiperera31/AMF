<%@ Page Language="C#" MasterPageFile="~/TaskManager.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="AMF.ManageCustomertasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel1" runat="server" BackColor="White">
    <div class="container">
        <h2><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Profile</b></h2>

        <div>
        <label for="txtId">Customer Id:</label><br />
        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
       
        <div>
            <label for="txtUsername">Customer Username:</label><br />
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
        <div>
            <label for="txtPassword">Customer Password:</label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
        <div>
            <label for="txtCompanyName">Customer Email:</label><br />
            <asp:TextBox ID="txtemail" runat="server" TextMode="Email" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
        <div>
            <label for="txtEmail">Customer Mobile:</label><br />
            <asp:TextBox ID="txtmobile" runat="server"  CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
        <div class="error">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
         <br /><br />
        <div class="button-container">
           <asp:Button ID="btndelete" runat="server" Text="Delete" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btndelete_Click" />
           <asp:Button ID="btnupdate" runat="server" Text="Update" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnupdate_Click" />
           <asp:Button ID="btnsearch" runat="server" Text="Search" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnsearch_Click" />
           
               &nbsp;</div>
        <br />
        
    </div>
        <br />

        </asp:Panel>
    
</asp:Content>
