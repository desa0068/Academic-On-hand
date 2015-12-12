<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacultyFinal.aspx.cs" Inherits="FacultyFinal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="FacultyFinalCss.css" />
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</head>
<body>
   
    <!-- Header -->
    <div id="header">
        <div class="shell">
            <!-- Logo + Top Nav -->
            <div id="top">
                <h1>
                    <a href="#" style="font-size: 22px">Attendance System</a></h1>
                <div id="top-navigation">
                    <asp:Label ID="lblloginname1" runat="server"></asp:Label>
                     
                    <span>|</span> <a href="Login.aspx">Log out</a>
                </div>
            </div>
            <!-- End Logo + Top Nav -->
            <!-- Main Nav -->
            <div id="navigation">
                
                <ul>
                    <li><a href="FacultyFinal.aspx"><span class="style1">Home</span></a></li>
                    <li><a href="ReportFaculty.aspx" class="active"><span class="style1">Reports</span></a></li>
                    
                    <li><a href="NotificationFaculty.aspx"><span class="style1">Alerts and Messages</span></a>
                     <ul>
                    <li><a href="NotificationFaculty.aspx">Send Alerts</a></li>
                    <li><a href="MessagesFaculty.aspx">Send Messages</a></li>
                    </ul>
                    </li>
                    
                   
                   
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
                <!-- End Box -->
                <div id="content">
              
            <img src="bookpen.jpg" class="Image" />
            <!-- Small Nav -->
            
        </div>
        <div class="cl">
                &nbsp;</div>
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
