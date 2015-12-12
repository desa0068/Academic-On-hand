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

public partial class NotificationFaculty : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1;
    OdbcDataAdapter da, da1;
    OdbcDataReader dr;
    DataSet ds, ds1;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        msger.Visible = false;
        msgri.Visible = false;
        lblloginname1.Text = Session["name"] + "";
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionErrorFaculty.aspx");
        }
        if (!IsPostBack)
        {
            cmd = new OdbcCommand("select course_name from course_detail", connection);
            da = new OdbcDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "course_detail");
            cb_stream.Items.Clear();
            cb_stream.Items.Insert(0, "Select");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cb_stream.Items.Insert(i + 1, ds.Tables[0].Rows[i][0].ToString());
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd1 = new OdbcCommand("select distinct sem from student_detail where course_id=(select course_id from course_detail where course_name='" + cb_stream.SelectedItem.Value + "')", connection);
        da1 = new OdbcDataAdapter(cmd1);
        ds1 = new DataSet();
        da1.Fill(ds1, "student_detail");
        cb_sem.Items.Clear();
        cb_sem.Items.Insert(0, "Select");
        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            cb_sem.Items.Insert(i + 1, ds1.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void txt_msg_TextChanged(object sender, EventArgs e)
    {
        Form1.Action = "http://adminpanel.webuda.com/try/show2.php";
    }
}