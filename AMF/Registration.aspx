<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="AMF.Registeration" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/login.css" rel="stylesheet" />
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <h3>Create Account</h3>
            
            <div class="input-box">
            <asp:TextBox ID="txtCId" runat="server" CssClass="form-control" placeholder="Customer Id" Width="347px" ></asp:TextBox>
             </div>
             <div class="input-box">
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Customer Username" Width="347px"></asp:TextBox>
            </div>
            <div class="input-box">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"  CssClass="form-control"  placeholder="Password" Width="347px"></asp:TextBox>
            </div>
            <div class="input-box">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" Width="347px"></asp:TextBox>
            </div>
           
            <div class="input-box">
            <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control"  placeholder="Mobile" Width="347px"></asp:TextBox>
            </div>
            
            <div class="error">
            <asp:Label ID="lblErrorMsg" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblDebugInfo" runat="server" Visible="false" />

            </div>
            <br /><br />
            <asp:Button ID="btnSignup" runat="server" Text="Sign-Up" CssClass="btn btn-primary" OnClick="btnSignup_Click" Height="50px" />
            <div class="register-link">
                <p>Have an account? <a href="login.aspx" class="rLink">Login</a></p>
            </div>
        </div>
    </form>
</body>
</html>
