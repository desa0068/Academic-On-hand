using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using System.Data.Odbc;
using System.Configuration;
using System.Web.Security;
using System.Net;

public partial class Try : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1, cmd2;
    OdbcDataAdapter oda, oda1, oda2;
    DataSet ds, ds1, ds2;
    OdbcDataReader dr;
    String stat;
    DateTime dt;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        connection.Open();
        cmd = new OdbcCommand("select course_name from course_detail", connection);
        dr = cmd.ExecuteReader();
        if (!IsPostBack)
        {
            cb_stream.DataSource = dr;
            cb_stream.DataTextField = "course_name";
            cb_stream.DataValueField = "course_name";
            cb_stream.DataBind();
        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        
    }
    protected void cb_stream_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnButton1_Click(object sender, EventArgs e)
    {
        
    }


    protected void txt_msg_TextChanged(object sender, EventArgs e)
    {
        Form1.Action = "http://adminpanel.webuda.com/try/show2.php";
    }
}