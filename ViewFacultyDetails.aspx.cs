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

public partial class ViewFacultyDetails : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcDataAdapter oda;
    DataSet ds;
    OdbcCommand cmd;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        b1.Visible = false;
        lblname.Text = Session["name"] + "";
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        cmd = new OdbcCommand("select * from faculty_detail", connection);
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionError.aspx");
        }
        oda = new OdbcDataAdapter(cmd);

        ds = new DataSet();
        oda.Fill(ds, "faculty_detail");
        b1.Visible = true;
        gvEmployee.Visible = true;
        gvEmployee.DataSource = ds.Tables[0];
        gvEmployee.DataBind();

    }



    protected void gvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}