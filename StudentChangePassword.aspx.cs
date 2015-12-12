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

public partial class StudentChangePassword : System.Web.UI.Page
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
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionError.aspx");
        }
        cmd = new OdbcCommand("select stud_id from student_detail", connection);
        oda = new OdbcDataAdapter(cmd);
        ds = new DataSet();
        oda.Fill(ds, "student_detail");

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ddstudid.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

    }

    protected void ddstudid_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void ddlresetpwd_SelectedIndexChanged1(object sender, EventArgs e)
    {
        
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtstudpwd.Value.Equals(txtstudconfirmpwd.Value))
        {
            cmd1 = new OdbcCommand("update student_detail set pwd='" + txtstudpwd.Value + "' where stud_id='" + ddstudid.SelectedItem.Value + "'", connection);
            cmd1.ExecuteNonQuery();
            msgri.Visible = true;
            msger.Visible = false;
            lblok.Text = "Record updated succesfully";
            
        }
        else
        {
                msgri.Visible = false;
                msger.Visible = true;
                lblerror.Text = "Confirm Password not equal to New Password";
            
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtstudconfirmpwd.Value = "";
        txtstudpwd.Value = "";

    }
}