<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacultyChangePassword.aspx.cs"
    Inherits="FacultyChangePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="FacultyChangePasswordCss.css" />
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
        .style2
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
                    <strong>
                        <asp:Label ID="lblname" runat="server"></asp:Label></strong> <span>|</span>
                    <a href="AccountManagement.aspx">Profile Settings</a> <span>|</span> <a href="Login.aspx">
                        Log out</a>
                </div>
            </div>
            <!-- End Logo + Top Nav -->
            <!-- Main Nav -->
            <div id="navigation">
                <ul>
                    <li><a href="Admin.aspx"><span class="style2">Home</span></a></li>
                    <li><a href="Reports.aspx" class="active"><span class="style2">Reports</span></a></li>
                    <li><a href="RegistrationCompleteFinal.aspx"><span class="style1">Registration</span></a>
                        <ul>
                            <li><a href="RegistrationCompleteFinal.aspx">Student</a></li>
                            <li><a href="RegisterFacultyFinal.aspx">Faculty</a></li>
                            <li><a href="RegisterSubject.aspx">Subject</a></li>
                            <li><a href="Course.aspx">Course</a></li>
                        </ul>
                    </li>
                    <li><a href="UpdateStudent.aspx"><span class="style1">Update</span></a>
                        <ul>
                            <li><a href="UpdateStudent.aspx">Student</a></li>
                            <li><a href="UpdateFaculty.aspx">Faculty</a></li>
                            <li><a href="UpdateSubjectDetails.aspx">Subject</a></li>
                            <li><a href="UpdateCourse.aspx">Course</a></li>
                            <li><a href="UpdateSemesterDetails.aspx">Semester</a></li>
                        </ul>
                    </li>
                    <li><a href="ViewStudentDetails.aspx"><span class="style1">View</span></a>
                        <ul>
                            <li><a href="ViewStudentDetails.aspx">Student</a></li>
                            <li><a href="ViewFacultyDetails.aspx">Faculty</a></li>
                            <li><a href="ViewSubjectDetails.aspx">Subject</a></li>
                            <li><a href="ViewCourseDetails.aspx">Course</a></li>
                        </ul>
                    </li>
                    <li><a href="Notification.aspx" class="style1">Alerts and Messages</a>
                        <ul>
                            <li><a href="Notification.aspx">Send Alerts</a></li>
                            <li><a href="Messages.aspx">Send Messages</a></li>
                        </ul>
                    </li>
                    <li><a href="FacultyChangePassword.aspx" class="style1">Settings</a>
                        <ul>
                            <li><a href="FacultyChangePassword.aspx">Reset Faculty Password</a></li>
                            <li><a href="StudentChangePassword.aspx">Reset Student Password</a></li>
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
            <!-- Small Nav -->
            <!-- End Small Nav -->
            <!-- Message OK -->
            <div class="msg msg-ok" id="msgri" runat="server">
                <p>
                    <strong>
                        <asp:Label ID="lblok" runat="server"></asp:Label></strong></p>
            </div>
            <!-- End Message OK -->
            <!-- Message Error -->
            <div class="msg msg-error" id="msger" runat="server">
                <p>
                    <strong>
                        <asp:Label ID="lblerror" runat="server"></asp:Label></strong></p>
            </div>
            <!-- End Message Error -->
            <div id="main">
                <div class="cl">
                    &nbsp;</div>
                <!-- Content -->
                <!-- End Box -->
                <div id="content">
                    <!-- Box -->
                    <!-- Box Head -->
                    <!-- End Box Head -->
                    <form id="Form1" class="contact_form" runat="server">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <br />
                    <div class="box">
                        <div class="box-head">
                            <h2 class="left">
                                Reset Faculty Password</h2>
                        </div>
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <*Denotes Required Field></span> &nbsp;</li>
                            <li id="Li2" class="contact_form" runat="server">
                                <label id="Label1" for="first name" runat="server">
                                    Select Id:</label>&nbsp; &nbsp;&nbsp;
                                <asp:DropDownList ID="ddfacid" runat="server" OnSelectedIndexChanged="ddfacid_SelectedIndexChanged"
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label id="Label2" for="password" runat="server">
                                    Enter New Password:</label>&nbsp; &nbsp;&nbsp;
                                <input type="password" name="newpwd" required id="txtfac_newpwd" runat="server" />
                            </li>
                            <li id="Li4" class="contact_form" runat="server">
                                <label id="Label3" for="password" runat="server">
                                    Enter Confirm Password:</label>&nbsp; &nbsp;&nbsp;
                                <input type="password" name="confirmpwd" required id="txtfac_confirmpwd" runat="server" />
                            </li>
                            <li class="contact_form">&nbsp;<br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
                                    Text="   Reset" BackColor="#99FF66" Font-Size="Large" Height="35px" Width="174px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Cancel" BackColor="#99FF66"
                                    Font-Size="Large" Height="35px" Width="177px" />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </li>
                        </ul>
                    </form>
                </div>
            </div>
        </div>
        <div class="cl">
            &nbsp;</div>
    </div>
    </div> </div>
    <div id="footer">
        <div class="shell">
            <span class="left">&copy; 2014 - All Rights Reserved</span> <span class="right">Design
                by Jay Thaker and Vaibhavi Desai </span>
        </div>
    </div>
</body>
</html>
