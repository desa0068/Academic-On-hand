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

public partial class IncrementAll : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
       

        cmd1 = new OdbcCommand("update student_detail set sem=sem+1 where 1", connection);
        cmd1.ExecuteNonQuery();

        //cmd = new OdbcCommand("select c.total_sem,s.sem,s.course_id from student_detail s,course_detail c where s.course_id=c.course_id", connection);
        cmd2 = new OdbcCommand("update student_detail,course_detail set status='" + "Inactive" + "' where student_detail.course_id=course_detail.course_id and sem > course_detail.total_sem", connection);
        cmd2.ExecuteNonQuery();      

       


       
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Server.Transfer("UpdateSemesterDetails.aspx");
    }
}