<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewFacultyDetails.aspx.cs"
    Inherits="ViewFacultyDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <title>Free CSS template by ChocoTemplates.com</title>
    <link rel="Stylesheet" type="text/css" href="ViewFacultyDetails.css" media="all" />
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
                
                    <a href="#"><h1>Attendance System</h1></a>
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
           

            <div id="Div1">
                <div class="cl">
                    &nbsp;</div>
                <!-- Content -->
                <div id="content">
                    <!-- End Message Error -->
                    <!-- Box Head -->
                    <div class="box-head" id="b1" runat="server">
                        <h2 class="left">
                            Faculty Details</h2>
                    </div>
                    <form id="form1" runat="server">
                    <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False" Width="814px"
                        CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr"
                        Height="186px" EnableModelValidation="True" OnSelectedIndexChanged="gvEmployee_SelectedIndexChanged">
                        <AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="fac_id" HeaderText="Faculty Id" SortExpression="fac_id" />
                            <asp:BoundField DataField="fname" HeaderText="FirstName" SortExpression="fname" />
                            <asp:BoundField DataField="mname" HeaderText="Middle Name" SortExpression="mname" />
                            <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
                            <asp:BoundField DataField="cont_no" HeaderText="Contact Number" SortExpression="cont_no" />
                            <asp:BoundField DataField="pwd" HeaderText="Password" SortExpression="pwd" />
                            <asp:BoundField DataField="role" HeaderText="Role" SortExpression="role" />
                        </Columns>
                    </asp:GridView>
                    </form>
                </div>
                <br />
                <!-- Main -->
            </div>
            <!-- End Box -->
        </div>
        <!-- End Content -->
        <div class="cl">
            &nbsp;</div>
    </div>
    <!-- Main -->
    </div> </div>
    <!-- End Container -->
    <!-- Footer -->
    <div id="footer">
        <div class="shell">
            <span class="left">&copy; 2014 - All Rights Reserved</span>&nbsp; <span class="right">
                Design by Jay Thaker and Vaibhavi Desai </span>
        </div>
    </div>
    <!-- End Footer -->
</body>
</html>
