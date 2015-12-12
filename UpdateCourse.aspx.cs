using System;
using System.Collections.Generic;
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

public partial class UpdateCourse : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcDataAdapter oda, oda1, oda2, oda3, oda4;
    DataSet ds, ds1, ds2, ds3, ds4;
    OdbcCommand cmd, cmd1, cmd2, cmd3, cmd4, cmd5;
    OdbcDataReader dr;
    OdbcDataReader dr1;
    OdbcDataReader dr2, dr3, dr4;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {

        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        cmd = new OdbcCommand("select course_id from course_detail", connection);
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionError.aspx");
        }
        dr = cmd.ExecuteReader();
        if (!IsPostBack)
        {
            ddcourseid.DataSource = dr;
            ddcourseid.DataValueField = "course_id";
            ddcourseid.DataTextField = "course_id";
            ddcourseid.DataBind();
            ddcourseid.Items.Insert(0, "Select");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd2 = new OdbcCommand("update course_detail set course_name='" + txtcourse_name.Value + "',total_sem='" + txtcourse_totalsem.Value + "' where course_id='"+ddcourseid.SelectedItem.Value+"'", connection);
        cmd2.ExecuteNonQuery();
        if (cmd2.ExecuteNonQuery() > 0)
        {
            msgri.Visible = true;

            lblok.Text = "Record updated succesfully";
        }
        else
        {
            lblerror.Text = "Record not updates";
        }
    }

    protected void ddcourseid_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        cmd1 = new OdbcCommand("select * from course_detail where course_id='" + ddcourseid.SelectedItem.Value + "'", connection);
        oda = new OdbcDataAdapter(cmd1);
        ds = new DataSet();
        oda.Fill(ds,"course_detail");

        txtcourse_name.Value = ds.Tables[0].Rows[0][1].ToString();
        txtcourse_totalsem.Value = ds.Tables[0].Rows[0][2].ToString();
    }
    protected void btnClear_Click(object sender, System.EventArgs e)
    {
        txtcourse_name.Value = "";
        txtcourse_totalsem.Value = "";
    }
}