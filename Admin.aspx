<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <title>Admin Panel</title>
    <link rel="stylesheet" href="style.css" type="text/css" media="all" />
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <!-- Header -->
    <div id="header">
        <div class="shell">
            <!-- Logo + Top Nav -->
            <div id="top">
                <h1>
                    <a href="#" style="font-size: 22px">Attendance System</a></h1>
                <div id="top-navigation">
                    <asp:Label ID="lblloginname" runat="server"></asp:Label>
                    <span>|</span> <a href="AccountManagement.aspx">Profile Settings</a> <span>|</span>
                    <a href="Login.aspx">Log out</a>
                </div>
            </div>
            <!-- End Logo + Top Nav -->
            <!-- Main Nav -->
            <div id="navigation">
                <ul>
                    <li><a href="Admin.aspx"><span class="style1">Home</span></a></li>
                    <li><a href="Reports.aspx" class="active"><span class="style1">Reports</span></a></li>
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
                    <li><a href="Notification.aspx"><span class="style1">Alerts and Messages</span></a>
                        <ul>
                            <li><a href="Notification.aspx">Send Alerts</a></li>
                            <li><a href="Messages.aspx">Send Messages</a></li>
                        </ul>
                    </li>
                    <li><a href="FacultyChangePassword.aspx"><span class="style1">Settings</span></a>
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
    <!-- End Footer -->
    </form>
</body>
</html>
