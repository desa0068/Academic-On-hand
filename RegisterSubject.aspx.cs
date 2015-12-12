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

public partial class RegisterSubject : System.Web.UI.Page
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

        odbcadap.SelectCommand = new OdbcCommand("Select * from subject_detail where sub_id='" + txtsub_id.Value + "'", connection);

        ds = new DataSet();


        odbcadap.Fill(ds, "subject_detail");

        if (ds.Tables[0].Rows.Count == 0)
        {
            cmd = new OdbcCommand("INSERT INTO subject_detail(sub_id,sub_name,course_id,sem,type,credit) VALUES('" + txtsub_id.Value + "','" + txtsub_name.Value + "','" + txtsub_courseid.Value + "','" + txtsub_sem.Value +"','"+type.Value+"','"+credit.Value+ "')", connection);
            cmd.ExecuteNonQuery();
            msgri.Visible = true;
            lblok.Text = "Subject Inserted Successfully";
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
        txtsub_id.Value = "";
        txtsub_name.Value = "";
        txtsub_courseid.Value = "";
        txtsub_sem.Value = "";
        //txtstud_batch.Value = "";
        //txtstud_courseid.Value = "";
        //txtstud_div.Value = "";
        //txtfac_emailid.Value = " ";
        //txtfac_password.Value = " ";
        // txtstud_pcontno.Value = "";
        //txtstud_regdate.Value = "0000-00-00";
        //txtfac_contno.Value = "";
        //txtstud_sem.Value = "";
        //txtfac_role.Value = "";
    }
}