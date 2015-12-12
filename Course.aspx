<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="RegisterCourse.css" />
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
                    <strong>
                        <asp:Label ID="lblname" runat="server"></asp:Label></strong> <span>|</span>
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
            <!-- Small Nav -->
            <!-- End Small Nav -->
            <!-- Message Error -->
            <div class="msg msg-ok" id="msgri" runat="server">
                <p>
                    <strong>
                        <asp:Label ID="lblok" runat="server"></asp:Label></strong></p>
            </div>
            <div class="msg msg-error" id="msger" runat="server">
                <p>
                    <strong>
                        <asp:Label ID="lblerror" runat="server"></asp:Label></strong></p>
            </div>
            <!-- End Message Error -->
            <br />
            <!-- Main -->
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <div id="main">
                <div class="cl">
                    &nbsp;</div>
                <!-- Content -->
                <div id="content">
                    <!-- Box -->
                    <br />
                    <br />
                    <div class="box">
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2 class="left">
                                Course Registration</h2>
                        </div>
                        <!-- End Box Head -->
                        <!-- Table -->
                        <form id="form1" runat="server">
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <* Denotes Required Field></span> </li>
                            <li id="Li2" class="contact_form" runat="server">
                                <label for="id">
                                    Enter id:</label>
                                <input type="text" required runat="server" id="txtcourse_id" />
                                <span class="form_hint">Enter character only"</span> </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label for="coursename">
                                    Enter Course Name:</label>
                                <input type="text" name="coursename" required runat="server" id="txtcourse_name" />
                                <span class="form_hint">Enter character only"</span> </li>
                            <li id="Li4" class="contact_form" runat="server">
                                <label for="total_sem">
                                    Enter Total Sem:</label>
                                <input type="text" name="total_sem" required runat="server" id="txtcourse_sem" />
                                <span class="form_hint">Enter character only</span> </li>
                            <li class="contact_form">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server"
                                    OnClick="Button1_Click" Text="   Register" Height="37px" Width="139px" BackColor="#99FF66"
                                    Font-Size="Large"></asp:Button>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" OnClick="btnClear_Click" Text="Reset" Height="37px"
                                    Width="139px" BackColor="#99FF66" Font-Size="Large"></asp:Button>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </li>
                        </ul>
                        </form>
                    </div>
                    <!-- Table -->
                </div>
                <!-- End Box -->
            </div>
            <!-- End Content -->
            <div class="cl">
                &nbsp;</div>
        </div>
        <!-- Main -->
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
