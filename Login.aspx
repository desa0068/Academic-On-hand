<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="layoutlogin.css" />
   
</head>
<body id="top">
    <form id="form1" runat="server">
    <div id="newsletter">
    </div>
    <div class="wrapper col1">
        <div id="header">
            <div align="center" class="style3">
                Attendance Management System</div>
        </div>
    </div>
    <div class="wrapper col3">
    </div>
    <div>
        <div id="container">
            <div class="wrap">
                <div class="avatar">
                    <img src="cmpicaimage.gif" width="353" height="353">
                </div>
                <input type="text" name="uname" placeholder="username" required id="usernm" runat="server" />
                <div class="bar">
                    <i></i>
                </div>
                <input type="password" name="pass" placeholder="password" required id="password"
                    runat="server" />&nbsp;
                <asp:Button ID="btn_signin" runat="server" OnClick="Button1_Click" Text="Sign In" />
            </div>
        </div>
    </div>
    <div class="wrapper col6">
    </div>
    <div class="wrapper col7">
        <div id="copyright">
            <div align="center">
                <p align="right">
                    <span class="style5"><strong>By Jay Thaker and Vaibhavi Desai</strong> </span>
                </p>
                <p align="right">
                    <span class="style7">Copyright &copy; 2014 - All Rights Reserved</span><br class="clear" />
                </p>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
