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
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd,cmd1,cmd2,cmd3,cmd4;
    OdbcDataAdapter oda,oda1,oda2,oda3;
    DataSet ds,ds1,ds2,ds3;
    OdbcDataReader dr,dr1;
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
       
        cmd = new OdbcCommand("select course_name from course_detail",connection);
        dr = cmd.ExecuteReader();
        if (!IsPostBack)
        {
            stud_course.DataSource = dr;
            stud_course.DataTextField = "course_name";
            stud_course.DataValueField = "course_name";
            stud_course.DataBind();
            stud_course.Items.Insert(0, "Select");
        }

        

    }
    protected void ddstudstream_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd1 = new OdbcCommand("select distinct sem from student_detail where course_id =(select course_id from course_detail where course_name='" + stud_course.SelectedItem.Value + "')", connection);
        oda1 = new OdbcDataAdapter(cmd1);
        ds1 = new DataSet();
        oda1.Fill(ds1, "student_detail");
        stud_sem.Items.Clear();
        stud_sem.Items.Insert(0, "Select");

        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            stud_sem.Items.Insert(i + 1, ds1.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void ddstudsem_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd2 = new OdbcCommand("select distinct stud_div from student_detail where course_id=(select course_id from course_detail where course_name='" + stud_course.SelectedItem.Value + "') and sem='" + stud_sem.SelectedItem.Value + "'", connection);
        oda2 = new OdbcDataAdapter(cmd2);
        ds2 = new DataSet();
        oda2.Fill(ds2, "student_detail");
        stud_div.Items.Clear();
        stud_div.Items.Insert(0, "Select");

        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
        {
            stud_div.Items.Insert(i + 1, ds2.Tables[0].Rows[i][0].ToString());
        }


    }
    protected void ddstuddiv_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd3 = new OdbcCommand("select stud_id from student_detail where course_id=(select course_id from course_detail where course_name='" + stud_course.SelectedItem.Value + "') and sem='" + stud_sem.SelectedItem.Value + "' and stud_div='" + stud_div.SelectedItem.Value + "'", connection);
        oda3 = new OdbcDataAdapter(cmd3);
        ds3 = new DataSet();
        oda3.Fill(ds3, "student_detail");
        ddstudid.Items.Clear();
        ddstudid.Items.Insert(0, "Select");
        

        for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
        {
            ddstudid.Items.Insert(i+1, ds3.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["course"] = stud_course.SelectedItem.Value;
        Session["semester"] = stud_sem.SelectedItem.Value;
        Session["division"] = stud_div.SelectedItem.Value;
        Session["stud_id"] = ddstudid.SelectedItem.Value;
        Response.Redirect("ReportDisplay.aspx");
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
    protected void ddstudid_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        /*string id;
        cmd4 = new OdbcCommand("select stud_id from student_detail where stud_id='" + ddstudid.SelectedItem.Value + "'", connection);
        dr1 = cmd4.ExecuteReader();

        StringBuilder str = new StringBuilder();

        str.Append("<chart palette='2' caption='Student Details',xAxisName='Student Id' showValues='1' labelStep='2' >");

        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
                id = dr1.GetString(0);
                string 
            }
        }*/

    }
}