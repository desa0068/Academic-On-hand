<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationCompleteFinal.aspx.cs"
    Inherits="RegistrationCompleteFinal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <title>Registration</title>
    <link rel="Stylesheet" type="text/css" href="RegistrationStudent.css" media="all" />
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
    <script language="javascript" type="text/javascript">

    </script>
</head>
<body>
    <!-- Header -->
    <div id="header">
        <div class="shell">
            <!-- Logo + Top Nav -->
            <div id="top">
                <h1>
                    <a href="#">Attendance System</a></h1>
                <div id="top-navigation">
                    <strong>
                      
                        <asp:Label ID="lblname" runat="server"></asp:Label></strong> <span>|</span>
                    <a href="AccountManagement.aspx">Profile Settings</a> <span>|</span> <a href="Login.aspx">Log out</a>
                </div>
                <br />
                <a href="Reports.aspx" class="active"><span class="style2">Reports</span></a><br />
                </div>
              
            <!-- End Logo + Top Nav -->
            <!-- Main Nav -->
            
            <!-- End Main Nav -->
            <div id="navigation">
                
                <ul>
                    <li><a href="Admin.aspx"><span class="style2">Home</span></a></li>
                    <li><a href="Reports.aspx"><span class="style2">Reports</span></a></li>
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
        </div>
    </div>
    <!-- End Header -->
    <!-- Container -->
    <div id="container">
        <div class="shell">
            <!-- Small Nav -->
           
            <!-- End Small Nav -->
            <!-- Message OK -->
            <br />
            <br />
            <br />
           
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
           
            <!-- Main -->
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
                                Student Registration</h2>
                        </div>
                        <!-- End Box Head -->
                        <!-- Table -->
                        <form class="contact_form" runat="server">
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <*Denotes Required Field></span> &nbsp;</li>
                            <li id="Li2" class="contact_form" runat="server">
                                <label id="Label1" for="id" runat="server">
                                    Enter Id:</label>&nbsp;
                                <input type="text" id="txtstud_id1" runat="server" required />
                                <span class="form_hint">*Please enter id</span> </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label id="Label2" for="first name" runat="server">
                                    Enter First Name:</label>&nbsp;
                                <input type="text" name="first_name" required id="txtstud_fname" runat="server" />
                            </li>
                            <li id="Li4" class="contact_form" runat="server">
                                <label for="middle_name">
                                    Enter Middle Name:</label>&nbsp;
                                <input type="text" name="middle_name" required id="txtstud_mname" runat="server" />
                                <span class="form_hint">*Please enter your middle name</span> </li>
                            <li id="Li5" class="contact_form" runat="server">
                                <label id="Label3" for="last_name" runat="server">
                                    Enter Last Name:</label>&nbsp;
                                <input type="text" name="last_name" required id="txtstud_lname" runat="server" />
                                <span class="form_hint">*Please enter your last name</span> </label> </li>
                            <li id="Li6" class="contact_form" runat="server">
                                <label id="Label4" for="course_id" runat="server">
                                   Select Course Name:</label>&nbsp;&nbsp;
                                <span class="form_hint">*Please enter your course id</span>
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                </asp:DropDownList>
                            </li>
                            <li class="contact_form">
                                <label for="sem">
                                    Enter Semester:</label>&nbsp;&nbsp;
                                <span class="form_hint">Please enter semester</span>
                                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                            <li class="contact_form">
                                <label for="division">
                                    Enter Division:</label>&nbsp;
                                <input type="text" name="division" required id="txtstud_div" runat="server" />
                                <span class="form_hint">Please enter division</span> </li>
                            <li class="contact_form">
                                <label for="emailid">
                                    Enter Email id:</label>&nbsp;
                                <input type="text" name="division" required id="txtstud_emailid" runat="server" />
                                <span class="form_hint">*Proper format "name@something.com"</span> </li>
                            <li class="contact_form">
                                <label for="student_cont_no">
                                    Enter Student Contact No:</label>&nbsp;
                                <input type="text" name="stud_cont_no" required id="txtstud_scontno" runat="server" />
                                <span class="form_hint">Please enter contact number in numeric form</span> </li>
                            <li class="contact_form">
                                <label for="parent_cont_no">
                                    Enter Parent Contact No:</label>&nbsp;
                                <input type="text" name="parent_cont_no" required id="txtstud_pcontno" runat="server" />
                                <span class="form_hint">Please enter contact number in numeric form</span> </li>
                            <li class="contact_form" id="regdt" >
                                <label for="reg_date">
                                    Enter Registration Date:</label>&nbsp;
                                &nbsp;<asp:Calendar 
                                    ID="Calendar1" runat="server" Height="16px" Width="222px" 
                                    onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
                                <br />
                            </li>
                            <li class="contact_form">
                                <label for="password">
                                    Enter Password:</label>&nbsp;
                                <input type="password" name="password" required id="txtstud_password" runat="server" />
                                <span class="form_hint">Please enter password</span> </li>
                            <li class="contact_form">
                                <label for="batch">
                                    Enter Batch:</label>&nbsp;
                                <input type="text" name="batch" required id="txtstud_batch" runat="server" />
                                <span class="form_hint">Please enter batch no</span> </li>
                            <li class="contact_form">
                                <label for="batch">
                                    Select Status:</label>&nbsp;
                                <input id="txtstud_status" readonly="readonly" type="text" value="Active" runat="server"/></li>
                            <li class="contact_form">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                ID="Button1" runat="server" OnClick="Button1_Click" Text="   Register" BackColor="#99FF66"
                                Font-Size="Large" Height="35px" Width="174px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                    ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Reset" BackColor="#99FF66"
                                    Font-Size="Large" Height="35px" Width="177px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </li>
                        </ul>
                        </form>
                    </div>
                    <!-- Table -->
                </div>
                <!-- End Box -->
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
                <span class="left">&copy; 2014 - All Rights Reserved </span>
            <span class="right">Design
                by Jay Thaker and Vaibhavi Desai </span>
            </div>
        </div>
        <!-- End Footer -->
        <!-- End Footer -->
</body>
</html>
