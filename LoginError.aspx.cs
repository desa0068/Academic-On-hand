using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.Odbc;
using System.Net;

public partial class LoginError : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcDataAdapter myadapter;
    DataSet ds;
    public String name;
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        WebClient client = new WebClient();
        byte[] datasize = null;
        try
        {
            datasize = client.DownloadData("http://www.google.com");
        }
        catch (Exception ex)
        {
        }
        if (datasize != null && datasize.Length > 0)
            Response.Write("");
        else
            Response.Write("Internet Connection Not Available.");

    }
    protected void openConnection()
    {

        connection.Open();
    }
    protected void closeConnection()
    {
        connection.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcCommand command = new OdbcCommand("SELECT * from faculty_detail", connection);
        myadapter = new OdbcDataAdapter();
        ds = new DataSet();

        myadapter.SelectCommand = command;

        try
        {
            openConnection();
            myadapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if ((usernm.Value.Equals(ds.Tables[0].Rows[i][0].ToString())) && (password.Value.Equals(ds.Tables[0].Rows[i][5].ToString())) && (ds.Tables[0].Rows[i][6].ToString().Equals("admin")))
                {
                    String adminname = "Welcome " + ds.Tables[0].Rows[i][1].ToString();
                    Session["name"] = adminname;
                    Response.Redirect("Admin.aspx");
                }
                if ((usernm.Value.Equals(ds.Tables[0].Rows[i][0].ToString())) && (password.Value.Equals(ds.Tables[0].Rows[i][5].ToString())))
                {
                    String facname = ds.Tables[0].Rows[i][1].ToString();

                    Session["name"] = "Welcome " + facname;
                    Response.Redirect("FacultyFinal.aspx");
                }
                if(!(usernm.Value.Equals(ds.Tables[0].Rows[i][0].ToString())) && (password.Value.Equals(ds.Tables[0].Rows[i][5].ToString())))
                {

                    Response.Redirect("LoginError.aspx");
                }


            }
        }
        catch (Exception ex)
        {

            throw (ex);
        }
        finally
        {
            closeConnection();
        }
    }
}