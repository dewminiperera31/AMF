<%@ Page Language="C#" MasterPageFile="~/TaskManager.Master" AutoEventWireup="true" CodeBehind="ManageCustomerTasks.aspx.cs" Inherits="AMF.ManageCustomerTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel1" runat="server" BackColor="White">
    <div class="container">
        <h2><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Task Manager</b></h2>

        <div>
        <label for="txtId">Task Id:</label><br />
        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
       
        <div>
            <label for="txtTitle">Title:</label><br />
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
        <div>
            <label for="txtDescription">Description:</label><br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" CssClass="form-control" Width="1000px" ></asp:TextBox><br />
        </div>
     
        <div class="error">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div class="button-container">
           <asp:Button ID="btnadd" runat="server" Text="Add" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnadd_Click" />
           <asp:Button ID="btndelete" runat="server" Text="Delete" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btndelete_Click" />
           <asp:Button ID="btnupdate" runat="server" Text="Update" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnupdate_Click" />
           <asp:Button ID="btnsearch" runat="server" Text="Search" BackColor="Black" Font-Bold="True" ForeColor="White" OnClick="btnsearch_Click" />
           
               &nbsp;</div>
        <br />
       
    </div>
        <br />

        </asp:Panel>
    
</asp:Content>
