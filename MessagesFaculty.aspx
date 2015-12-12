<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessagesFaculty.aspx.cs" Inherits="MessagesFaculty" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="MessagesFacultyCss.css" />
    <script language="javascript" type="text/javascript">

        function btnSubmit_onclick() {
            var f_obj = document.getElementById("Form1");
            f_obj.action = "http://adminpanel.webuda.com/try/show3.php";
            f_obj.submit();
        }

       
    </script>
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
                        <asp:Label ID="lblloginname1" runat="server"></asp:Label></strong> <span>|</span>
                    <a href="Login.aspx">Log out</a>
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
    <div id="container">
        <div class="shell">

       
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
            <div id="main">
                <div class="cl">
                    &nbsp;</div>
                <!-- Content -->
                <!-- End Box -->
                <div id="content">
            <div class="box">
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2 class="left">
                                Send Messages</h2>
                        </div>
                        <!-- End Box Head -->
                        <form id="Form1" runat="server">
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <*Denotes Required Field></span> &nbsp;</li>
                            <li id="Li2" class="contact_form" runat="server">
                               
                                <input type="hidden" ID="cb_fid" runat="server"  name="cb_fid"
                                    />
                                
                            </li>
                            
                              <li id="Li4" class="contact_form" runat="server">
                                <label id="Label1" for="stream" runat="server">
                                    Select Stream:</label>&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="cb_stream" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                </asp:DropDownList>
                            </li>
                            <li id="Li6" class="contact_form" runat="server">
                                <label id="Label6" for="semester" runat="server">
                                    Select Semester:</label>&nbsp;&nbsp;
                                <span class="form_hint">*Please enter subject name</span>&nbsp;
                                <asp:DropDownList ID="cb_sem" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="cb_sem_SelectedIndexChanged">
                                </asp:DropDownList>
                            </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label id="Label2" for="semester" runat="server">
                                    Enter Student Id:</label>&nbsp;&nbsp;
                                <span class="form_hint">*Please enter subject name</span>
                                
                                <asp:DropDownList ID="cb_sid" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                               </li>
                                
                             <li id="Li5" class="contact_form" runat="server">
                                <label for="course_name">
                                    Enter Message:</label>&nbsp;
                                 <asp:TextBox ID="txt_msg" runat="server" ontextchanged="txt_msg_TextChanged"></asp:TextBox>
                            </li>
                            <li class="contact_form">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="button"
                               ID="btnSubmit" runat="server" onclick="btnSubmit_onclick()" value="   Send" 
                                    style="background-color: #00FF00; font-weight: normal; font-size: large;" 
                                    />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:Button
                                    ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" BackColor="#99FF66"
                                    Font-Size="Large" Height="35px" Width="188px" />
                                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;                               
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </li>
                            </ul>
                            </form>
                            </div>
                           
        </div>
         <div class="cl">
                    &nbsp;</div>
    </div>
    </div>
    </div>
    <div id="footer">
        <div class="shell">
            <span class="left">&copy; All Rights Reserved</span> <span class="right">Design by Jay
                Thaker and Vaibhavi Desai </span>
        </div>
    </div>
</body>
</html>
