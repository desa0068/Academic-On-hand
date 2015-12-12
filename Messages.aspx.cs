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

public partial class Messages : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd,cmd1,cmd2,cmd3;
    OdbcDataAdapter da,da1,da2,da3;
    OdbcDataReader dr;
    DataSet ds,ds1,ds2,ds3;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Form1_Load(object sender, EventArgs e)
    {
        Page_Load(sender,e);


    }

    protected void Page_Load(object sender, EventArgs e)
    {
       
        msger.Visible = false;
        msgri.Visible = false;
        lblname.Text = Session["name"] + "";
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);

        cb_fid.Value = Session["id"] + "";
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionError.aspx");
        }
        cmd1 = new OdbcCommand("select course_name from course_detail", connection);
        dr = cmd1.ExecuteReader();




        if (!IsPostBack)
        {
            cmd = new OdbcCommand("select course_name from course_detail", connection);
            da = new OdbcDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "course_detail");
            cb_stream.Items.Clear();
            cb_stream.Items.Insert(0, "Select");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cb_stream.Items.Insert(i + 1, ds.Tables[0].Rows[i][0].ToString());
            }
        }
            
    }
    /*protected void btnClear_Click(object sender, EventArgs e)
    {

    }*/
    
    protected void ddstudsemester_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*cmd3 = new OdbcCommand("select stud_id from student_detail where g_regid is not null and course_id=(select course_id from course_detail where course_name='" + ddstudstream.SelectedItem.Value + "') and sem='" + ddstudsemester.SelectedItem.Value + "'", connection);
        da3 = new OdbcDataAdapter(cmd3);
        ds3 = new DataSet();
        da3.Fill(ds3, "student_detail");
        ddlstudid.Items.Clear();
        ddlstudid.Items.Insert(0, "Select");
        for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
        {
            ddlstudid.Items.Insert(i + 1, ds3.Tables[0].Rows[i][0].ToString());
            
        }
        cb_sid.Value = ddlstudid.SelectedItem.Value;
    }
    
protected void  ddstudstream_SelectedIndexChanged(object sender, EventArgs e)
{
    /*cmd2 = new OdbcCommand("select distinct sem from student_detail where course_id=(select course_id from course_detail where course_name='" + ddstudstream.SelectedItem.Value + "')", connection);
    da2 = new OdbcDataAdapter(cmd2);
    ds2 = new DataSet();
    da2.Fill(ds2, "student_detail");
    ddstudsemester.Items.Clear();
    ddstudsemester.Items.Insert(0, "Select");
    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
    {
        ddstudsemester.Items.Insert(i + 1, ds2.Tables[0].Rows[i][0].ToString());
    }*/
}
protected void ddstudid_SelectedIndexChanged(object sender, EventArgs e)
{
   


}
protected void Button1_Click(object sender, EventArgs e)
{

}
protected void btnClear_Click(object sender, EventArgs e)
{
    cb_stream.Items.Clear();
    cb_sem.Items.Clear();
    cb_sid.Items.Clear();

    

}
protected void txt_msg_TextChanged(object sender, EventArgs e)
{
    Form1.Action = "http://adminpanel.webuda.com/try/show3.php";
}
protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{
    cmd1 = new OdbcCommand("select distinct sem from student_detail where course_id=(select course_id from course_detail where course_name='" + cb_stream.SelectedItem.Value + "')", connection);
    da1 = new OdbcDataAdapter(cmd1);
    ds1 = new DataSet();
    da1.Fill(ds1, "student_detail");
    cb_sem.Items.Clear();
    cb_sem.Items.Insert(0, "Select");
    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
    {
        cb_sem.Items.Insert(i + 1, ds1.Tables[0].Rows[i][0].ToString());
    }
}
protected void cb_sem_SelectedIndexChanged(object sender, EventArgs e)
{
    cmd2 = new OdbcCommand("select stud_id from student_detail where course_id=(select course_id from course_detail where course_name='" + cb_stream.SelectedItem.Value + "') and sem='" + cb_sem.SelectedItem.Value + "'", connection);
    da2 = new OdbcDataAdapter(cmd2);
    ds2 = new DataSet();
    da2.Fill(ds2, "student_detail");
    cb_sid.Items.Clear();
    cb_sid.Items.Insert(0, "Select");
    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
    {
       cb_sid.Items.Insert(i+1, ds2.Tables[0].Rows[i][0].ToString());
    }

   
}
}