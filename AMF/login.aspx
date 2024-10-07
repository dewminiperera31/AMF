<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AMF.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/login.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <img src="Images/t1.png" class="fast" alt="Logo"/>
            <br/><br/>
            <h1 style="text-align:center;">Login</h1>
            <br />
           
            <div class="input-box">
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" required="required" Height="16px" Width="347px"></asp:TextBox>
                <i class='bx bxs-user'></i>
            </div>
           
            <div class="input-box">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password" required="required" Height="16px" Width="347px"></asp:TextBox>
                <i class='bx bxs-lock'></i>
            </div>
            
            <div class="error">
                <asp:Label ID="lblErrorMsg" runat="server" Text="" ForeColor="Red"></asp:Label><br />
                <asp:Label ID="lblDebugInfo" runat="server" Visible="false" /><br />

                </div>
            <br />
         

            
            <asp:Button ID="btnSubmit" runat="server" Text="Sign-In" CssClass="btn" OnClick="btnSubmit_Click" />
              
            <div class="register-link">
                <p>Don't have an account? 
                    <a href="Registration.aspx" class="rLink">Customer Register</a>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
