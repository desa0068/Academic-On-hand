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

public partial class ViewCourseDetails : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcDataAdapter oda;
    DataSet ds;
    OdbcCommand cmd, cmd1;
    OdbcDataReader dr;
    OdbcDataReader dr1;
    OdbcDataReader dr2, dr3;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        b1.Visible = false;
        lblname.Text = Session["name"] + "";
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        cmd = new OdbcCommand("select course_name from course_detail", connection);
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
            course_name.DataSource = dr;
            course_name.DataValueField = "course_name";
            course_name.DataTextField = "course_name";
            course_name.DataBind();
            course_name.Items.Insert(0, "Select");
        }
    }
    protected void course_name_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd1 = new OdbcCommand("select * from course_detail where course_name='" + course_name.SelectedItem.Value + "'", connection);
        oda = new OdbcDataAdapter(cmd1);
        ds = new DataSet();
        oda.Fill(ds,"course_detail");
        b1.Visible = true;
        gvEmployee.Visible = true;
        gvEmployee.DataSource = ds.Tables[0];
        gvEmployee.DataBind();
    }
}