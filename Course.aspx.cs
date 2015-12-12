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

public partial class Course : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd;
    OdbcDataAdapter odbcadap = new OdbcDataAdapter();
    DataSet ds;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionError.aspx");
        }

        //cmd = new OdbcCommand("Select * from student_detail", connection);

        odbcadap.SelectCommand = new OdbcCommand("Select * from course_detail where course_id='" + txtcourse_id.Value + "'", connection);

        ds = new DataSet();


        odbcadap.Fill(ds, "course_detail");

        if (ds.Tables[0].Rows.Count == 0)
        {
            cmd = new OdbcCommand("INSERT INTO course_detail(course_id,course_name,total_sem) VALUES('" + txtcourse_id.Value + "','" + txtcourse_name.Value + "','" + txtcourse_sem.Value + "')", connection);
            cmd.ExecuteNonQuery();
            msgri.Visible = true;
            lblok.Text = "Record inserted successfully";
        }
        else
        {
            msger.Visible = true;
            lblerror.Text = "Record already exists";
        }

        connection.Close();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtcourse_id.Value = "";
        txtcourse_name.Value = "";
        txtcourse_sem.Value = "";
        
    }
}