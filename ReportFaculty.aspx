<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportFaculty.aspx.cs" Inherits="ReportFaculty" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <title>Reports</title>
    <link rel="stylesheet" href="ReportFaculty.css" type="text/css" media="all" />
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
                    <strong>
                        <asp:Label ID="lblname" runat="server"></asp:Label></strong> <span>|</span>
                    <a href="AccountManagement.aspx">Profile Settings</a> <span>|</span> <a href="Login.aspx">Log out</a>
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
              
           
            <!-- Small Nav -->
            <div class="box">
                        <!-- Box Head -->
                        <div class="box-head" id="b1" runat="server">
                            <h2 class="left">
                                Report</h2>
                                 <form id="Form1" class="contact_form" runat="server">
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <*Denotes Required Field></span> &nbsp;</li>
                           <li id="Li4" class="contact_form" runat="server">
                                <label id="Label3" for="first name" runat="server">
                                    Select Stream:</label>&nbsp; &nbsp;&nbsp;
                                <asp:DropDownList ID="stud_course" runat="server" OnSelectedIndexChanged="ddstudstream_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label id="Label2" for="first name" runat="server">
                                    Select Semester:</label>&nbsp; &nbsp;&nbsp;
                                <asp:DropDownList ID="stud_sem" runat="server" OnSelectedIndexChanged="ddstudsem_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                             <li id="Li5" class="contact_form" runat="server">
                                <label id="Label4" for="first name" runat="server">
                                    Select Division:</label>&nbsp; &nbsp;&nbsp;
                                <asp:DropDownList ID="stud_div" runat="server" OnSelectedIndexChanged="ddstuddiv_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                            <li id="Li2" class="contact_form" runat="server">
                                <label id="Label1" for="first name" runat="server">
                                    Select Id:</label>&nbsp; &nbsp;&nbsp;
                                <asp:DropDownList ID="ddstudid" runat="server" OnSelectedIndexChanged="ddstudid_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                           
                            <li class="contact_form">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                ID="Button1" runat="server" OnClick="Button1_Click" Text="   Generate Report" BackColor="#99FF66"
                                Font-Size="Large" Height="35px" Width="220px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                    ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Reset" BackColor="#99FF66"
                                    Font-Size="Large" Height="35px" Width="177px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </li>
                           </ul>
                        </form>
                        </div>
                        <!-- End Box Head -->
                        
                        <!-- Table -->
                    </div>
                    <!-- Table -->
              
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
    <!-- End Footer -->

</body>
</html>
