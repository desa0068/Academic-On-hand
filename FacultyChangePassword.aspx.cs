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

public partial class FacultyChangePassword : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1, cmd2;
    OdbcDataAdapter oda, oda1, oda2;
    DataSet ds, ds1, ds2;
    OdbcDataReader dr;
    String stat;
    DateTime dt;
    WebClient client = new WebClient();
    byte[] datasize = null;
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
        cmd = new OdbcCommand("select fac_id from faculty_detail", connection);
        oda = new OdbcDataAdapter(cmd);
        ds = new DataSet();
        oda.Fill(ds, "faculty_detail");

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ddfacid.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void ddlresetpwd_SelectedIndexChanged1(object sender, EventArgs e)
    {
        

    }
    protected void ddfacid_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtfac_newpwd.Value.Equals(txtfac_confirmpwd.Value))
        {
            cmd1 = new OdbcCommand("update faculty_detail set pwd='" + txtfac_newpwd.Value + "' where fac_", connection);
            cmd1.ExecuteNonQuery();
            msgri.Visible = true;
            msger.Visible=false;
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
        txtfac_confirmpwd.Value = "";
        txtfac_newpwd.Value = "";
        
    }
}