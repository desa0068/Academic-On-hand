<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Try.aspx.cs" Inherits="Try" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="NotificationCss.css" />


<script language="javascript" type="text/javascript">

    function btnSubmit_onclick() {
        var f_obj = document.getElementById("Form1");
        f_obj.action = "http://adminpanel.webuda.com/try/show2.php";
        f_obj.submit();
    }

</script>
</head>
<body>
    <div id="header">
        <div class="shell">
            <!-- Logo + Top Nav -->
            <div i
// p">
                <h1>
                    <a href="#">Attendance System</a></h1>
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
                    <li><a href="Admin.aspx"><span>Home</span></a></li>
                    <li><a href="Reports.aspx"><span>Reports</span></a></li>
                    <li><a href="RegistrationCompleteFinal.aspx" ><span>Registration</span></a></li>
                    <li><a href="AccountManagement.aspx"><span>Account Management</span></a></li>
                    <li><a href="Notification.aspx" class="active"><span>Alerts and Notifications</span></a></li>
                </ul>
            </div>
            <!-- End Main Nav -->
        </div>
    </div>
    <div id="container">
        <div class="shell">
        <div class="small-nav">
        <a href="#">Notification</a><span> | </span><a href="Messages.aspx">Messages</a>
        </div>
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
            <div class="box">
                        <!-- Box Head -->
                        <div class="box-head">
                            <h2 class="left">
                                Send Notification</h2>
                        </div>
                        <!-- End Box Head -->
                        <form id="Form1" name="form1" class="contact_form" runat="server" method="post">
                        <ul id="Ul1" class="contact_form" runat="server">
                            <li id="Li1" class="contact_form" runat="server"><span class="required_notification">
                                <*Denotes Required Field></span> &nbsp;</li>
                            <li id="Li2" class="contact_form" runat="server">
                                <label id="Label1" for="stream" runat="server">
                                    Select Stream:</label>&nbsp;&nbsp;
                               <asp:DropDownList id="cb_stream"  runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="cb_stream_SelectedIndexChanged" Height="16px"></asp:DropDownList>
                            </li>
                            <li id="Li3" class="contact_form" runat="server">
                                <label id="Label2" for="semester" runat="server">
                                    Select Semester:</label>&nbsp;&nbsp;
                                <span class="form_hint">*Please enter subject name</span> 
                                <input type="text" id="cb_sem" name="cb_sem" runat="server"/>
                            </li>
                            <li id="Li4" class="contact_form" runat="server">
                                <label for="course_name">
                                    Enter Subject:</label>&nbsp;&nbsp; <span class="form_hint">*Please enter course
                                        name</span>
                                <input type="text" runat="server" name="txt_sub" id="txt_sub" />
                            </li>
                            <li id="Li5" class="contact_form" runat="server">
                                <label for="course_name">
                                    Enter Message:</label>&nbsp;&nbsp; <span class="form_hint">*Please enter course
                                        name</span>
                                <asp:TextBox ID="txt_msg" runat="server" ontextchanged="txt_msg_TextChanged" 
                                    AutoPostBack="True"></asp:TextBox></li>
                          <li id="Li6" class="contact_form" runat="server"><input type="button"
                                    ID="btnSubmit" runat="server" onclick="btnSubmit_onclick()" value="Submit"   />
                                &nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                                    ID="btnClear0" runat="server" OnClick="btnClear_Click" Text="Clear" BackColor="#99FF66"
                                    Font-Size="Large" Height="35px" Width="177px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </li>
                            </ul>
                            </form>

                            </div>
                            <div class="cl">
                    &nbsp;</div>
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
