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


public partial class ViewStudentDetails : System.Web.UI.Page
{

    OdbcConnection connection;
    OdbcDataAdapter oda;
    DataSet ds;
    OdbcCommand cmd,cmd1;
    OdbcDataReader dr;
    OdbcDataReader dr1;
    OdbcDataReader dr2,dr3;
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
       
        //ds = new DataSet();
        //oda.Fill(ds, "student_detail");
        
        if (!IsPostBack)
        {
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "course_name";
            DropDownList1.DataTextField = "course_name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
        }

    
        


    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd = new OdbcCommand("select total_sem from course_detail where course_name='"+DropDownList1.SelectedItem.Value+"'", connection);
       
        dr1 = cmd.ExecuteReader();
        DropDownList2.Items.Clear();
        DropDownList2.DataSource = dr1;
        DropDownList2.Items.Insert(0, "Select");
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.GetInt32(0); i++)
                {
                    
                        DropDownList2.Items.Add(new ListItem((i + 1).ToString()));
                                
                    
                }
                
            }
          
        }
        

    }



    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd = new OdbcCommand("select distinct stud_div from student_detail where course_id=(select course_id from course_detail where course_name='" + DropDownList1.SelectedItem.Value + "') and sem='" + DropDownList2.SelectedItem.Value + "'", connection);
        dr3 = cmd.ExecuteReader();
     
        DropDownList3.DataSource = dr3;
        DropDownList3.DataValueField = "stud_div";
        DropDownList3.DataTextField = "stud_div";
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "Select");


    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd = new OdbcCommand("select * from student_detail where course_id=(select course_id from course_detail where course_name='" + DropDownList1.SelectedItem.Value + "') and sem='" + DropDownList2.SelectedItem.Value + "' and stud_div='"+DropDownList3.SelectedItem.Value+"'", connection);

        cmd1=new OdbcCommand("select course_name from course_detail where course_name='"+DropDownList1.SelectedItem.Value+"'",connection);
        oda = new OdbcDataAdapter(cmd);

        ds = new DataSet();
        oda.Fill(ds, "student_detail");
        b1.Visible = true;
        gvEmployee.Visible = true;
        gvEmployee.DataSource = ds.Tables[0];
        gvEmployee.DataBind();
    }
    protected void gvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}