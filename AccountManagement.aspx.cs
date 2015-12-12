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

public partial class AccountManagement : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1, cmd2;
    OdbcDataAdapter oda, oda1, oda2;
    DataSet ds, ds1, ds2;
    OdbcDataReader dr;
    String stat;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Session["name"] + "";
        
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
        
        

    }
    protected void ddfacid_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
    
    protected void ddstudid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlresetpwd_SelectedIndexChanged1(object sender, EventArgs e)
    {
       
    }
}