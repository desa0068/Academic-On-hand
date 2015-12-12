<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterFacultyFinal.aspx.cs"
    Inherits="RegisterFacultyFinal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <title>Free CSS template by ChocoTemplates.com</title>
    <link rel="stylesheet" href="RegistrationFaculty.css" type="text/css" media="all" />
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
                     <a href="AccountManagement.aspx">Profile Settings</a> <span>|</span>
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
                    <div class="box">
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2 class="left">
                                Faculty Registration</h2>
                        </div>
                        <!-- End Box Head -->
                        <!-- Table -->
                        <form id="form1" runat="server">
                        <ul class="contact_form" runat="server">
                            <li class="contact_form" runat="server"><span class="required_notification"><* Denotes
                                Required Field></span> </li>
                            <li class="contact_form" runat="server">
                                <label for="id">
                                    Enter id:</label>
                                <input type="text" required runat="server" id="txtfac_id" />
                                <span class="form_hint">Enter character only</span> </li>
                            </li>
                            <li class="contact_form" runat="server">
                                <label for="firstname">
                                    Enter First Name:</label>
                                <input type="text" name="firstname" required runat="server" id="txtfac_fname" />
                                <span class="form_hint">Enter character only"</span> </li>
                            <li class="contact_form" runat="server">
                                <label for="middlename">
                                    Enter Middle Name:</label>
                                <input type="text" name="middlename" required runat="server" id="txtfac_mname" />
                                <span class="form_hint">Enter character only</span> </li>
                            <li class="contact_form" runat="server">
                                <label for="lastname">
                                    Enter Last Name:</label>
                                <input type="text" name="lastname" required runat="server" id="txtfac_lname" />
                                <span class="form_hint">Enter character only</span> </li>
                            <li class="contact_form" runat="server">
                                <label for="contactnumber">
                                    Enter Contact Number:</label>
                                <input type="text" name="contactnumber" required runat="server" id="txtfac_contno" />
                                <span class="form_hint">Enter numbers only</span> </li>
                            <li class="contact_form" runat="server">
                                <label for="password">
                                    Enter Password:</label>
                                <input type="password" name="password" required runat="server" id="txtfac_password" />
                                <span class="form_hint">Enter character only</span> </li>
                            <li class="contact_form" runat="server">
                                <label for="role">
                                    Enter Role:</label>
                                <input type="text" name="role" required runat="server" id="txtfac_role" />
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
    <!-- End Footer -->
</body>
</html>
