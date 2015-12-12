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

public partial class DecrementSemester : System.Web.UI.Page
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
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        connection.Open();
        cmd = new OdbcCommand("select course_name from course_detail", connection);
        dr = cmd.ExecuteReader();


        if (!IsPostBack)
        {

            ddstudstream.DataSource = dr;
            ddstudstream.DataTextField = "course_name";
            ddstudstream.DataValueField = "course_name";
            ddstudstream.DataBind();
            ddstudstream.Items.Insert(0, "Select");
        }

    }

    protected void ddstudstream_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        ddstudsemester.Items.Clear();
        cmd1 = new OdbcCommand("select sem from student_detail where course_id=(select course_id from course_detail where course_name='" + ddstudstream.SelectedItem.Value + "')", connection);
        oda = new OdbcDataAdapter(cmd1);
        ds = new DataSet();
        oda.Fill(ds, "student_detail");
        ddstudsemester.Items.Insert(0, "Select");

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ddstudsemester.Items.Insert(i + 1, ds.Tables[0].Rows[i][0].ToString());
        }

    }
    protected void ddstudsem_SelectedIndexChanged(object sender, System.EventArgs e)
    {

        ddlstudstudid.Items.Clear();
        cmd2 = new OdbcCommand("select stud_id from student_detail where course_id=(select course_id from course_detail where course_name='" + ddstudstream.SelectedItem.Value + "') and sem='" + ddstudsemester.SelectedItem.Value + "'", connection);
        oda1 = new OdbcDataAdapter(cmd2);
        ds1 = new DataSet();
        oda1.Fill(ds1);

        ddlstudstudid.Items.Insert(0, "Select");

        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            ddlstudstudid.Items.Insert(i + 1, ds1.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void Button1_Click(object sender, System.EventArgs e)
    {
        cmd3 = new OdbcCommand("update student_detail set sem=sem-1 where stud_id='" + ddlstudstudid.SelectedItem.Value + "'", connection);

        cmd3.ExecuteNonQuery();

        cmd4 = new OdbcCommand("update student_detail,course_detail set status='" + "Inactive" + "' where stud_id='" + ddlstudstudid.SelectedItem.Value + "' and student_detail.course_id=course_detail.course_id and student_detail.sem > course_detail.total_sem", connection);
        cmd4.ExecuteNonQuery();
    }
    protected void btnClear_Click(object sender, System.EventArgs e)
    {
        Server.Transfer("UpdateSemesterDetails.aspx");
    }
}