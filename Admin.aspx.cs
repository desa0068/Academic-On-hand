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

public partial class _Default : System.Web.UI.Page
{

    OdbcConnection connection;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Page_Load(object sender, EventArgs e)
    {
            lblloginname.Text = Session["name"] + "";

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
      
    
    protected void openConnection()
    {
        

    }
    protected void closeConnection()
    {

    }


   /* protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        /*  if (Menu1.SelectedValue.Equals("Register Faculty Details"))
          {
              //myadapter.InsertCommand=new OdbcCommand("INSERT INTO faculty_detail(fac_id,fname,mname,lname,cont_no,email_id,pwd,role) VALUES(?,?,?,?,?,?,?,?))");
              Response.Redirect("RegisterFaculty.aspx");
          }
          if (Menu1.SelectedValue.Equals("Register Student Details"))
          {
              Response.Redirect("RegisterStudent.aspx");
          }

    }*/
}