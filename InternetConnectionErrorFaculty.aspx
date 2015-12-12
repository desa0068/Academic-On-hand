<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InternetConnectionErrorFaculty.aspx.cs" Inherits="InternetConnectionErrorFaculty" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="InternetConnectionErrorFaculty.css" />
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</head>
<body>
      <div id="header">
        <div class="shell">
            <!-- Logo + Top Nav -->
            <div id="top">
                <h1>
                    <a href="#" style="font-size: 22px">Attendance System</a></h1>
                <div id="top-navigation">
                    <asp:Label ID="lblloginname" runat="server"></asp:Label>
                     <span>|</span> <a href="AccountManagement.aspx">Profile Settings</a>
                    <span>|</span> <a href="Login.aspx">Log out</a>
                </div>
            </div>
            <!-- End Logo + Top Nav -->
            <!-- Main Nav -->
            <div id="navigation">
                <ul>
                   <li><a href="FacultyFinal.aspx" class="active"><span class="style1">Home</span></a></li>
                    <li><a href="ReportFaculty.aspx"><span class="style1">Reports</span></a></li>
                    <li><a href="NotificationFaculty.aspx"><span class="style1">Alerts and Notifications</span></a></li>
                </ul>
            </div>
            <!-- End Main Nav -->
        </div>
    </div>
    <!-- End Header -->
    <!-- Container -->
    <div id="container">
        <div class="shell">
        <div id="main">
                <div class="cl">
                    &nbsp;</div>
                <!-- Content -->
                <div id="content">
                <br />
                <br />
                <br />
                <br />

           <div class="msg msg-error" id="msger" runat="server">
                <p>
                
                    <strong>
                        <asp:Label ID="lblerror" runat="server">Internet Connection Not Availaible</asp:Label></strong></p>
                
            </div>
            <!-- Small Nav -->
              

    <!-- End Container -->
    <!-- Footer -->
    </div>
        <!-- Main -->
         <div class="cl">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
           
    </div>
    </div>
    </div>
    <!-- End Container -->
    <!-- Footer -->
    <div id="footer">
        <div class="shell">
            <span class="left">&copy; 2014 - All Rights Reserved</span> <span class="right">Design
                by Jay Thaker and Vaibhavi Desai </span>
        </div>
    </div>
</body>
</html>
