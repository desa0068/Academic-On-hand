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

public partial class UpdateSubjectDetails : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcDataAdapter oda,oda1,oda2,oda3,oda4;
    DataSet ds,ds1,ds2,ds3,ds4;
    OdbcCommand cmd, cmd1,cmd2,cmd3,cmd4,cmd5;
    OdbcDataReader dr;
    OdbcDataReader dr1;
    OdbcDataReader dr2, dr3,dr4;
    byte[] datasize = null;
    WebClient client = new WebClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        cmd = new OdbcCommand("select sub_id from subject_detail", connection);
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
        if (!IsPostBack)
        {
            ddstudid.DataSource = dr;
            ddstudid.DataTextField = "sub_id";
            ddstudid.DataValueField = "sub_id";
            ddstudid.DataBind();
            ddstudid.Items.Insert(0, "Select");


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new OdbcCommand("update subject_detail set sub_name='" + txtsub_name.Value + "',course_id=(select course_id from course_detail where course_name='" + ddlsub_coursename.SelectedItem.Value + "'),course_id=(select course_id from course_detail where course_name='" + ddlsub_coursename.SelectedItem.Value + "'),sem='" + ddlsub_semester.SelectedItem.Value + "',type='" + ddlsub_type.SelectedItem.Value + "',credit='" + ddlsub_credit.SelectedItem.Value + "' where sub_id='" + ddstudid.SelectedItem.Value + "'", connection);
        cmd.ExecuteNonQuery();
        if (cmd.ExecuteNonQuery() > 0)
        {
            msgri.Visible = true;

            lblok.Text = "Record updated succesfully";
        }
        else
        {
            lblerror.Text = "Record not updates";
        }
    }
    protected void ddstudid_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        ddlsub_coursename.Items.Clear();
        ddlsub_credit.Items.Clear();
        ddlsub_semester.Items.Clear();
        ddlsub_type.Items.Clear();
       
        cmd = new OdbcCommand("select * from subject_detail where sub_id='"+ddstudid.SelectedItem.Value+"'", connection);
        cmd1 = new OdbcCommand("select course_name from course_detail where course_id=(select course_id from subject_detail where sub_id='" + ddstudid.SelectedItem.Value + "')", connection);
        cmd2 = new OdbcCommand("select course_name from course_detail", connection);
        cmd3 = new OdbcCommand("select total_sem from course_detail where course_id=(select course_id from subject_detail where sub_id='"+ddstudid.SelectedItem.Value+"')", connection);
        cmd4 = new OdbcCommand("select distinct type from subject_detail", connection);
        cmd5 = new OdbcCommand("select distinct credit from subject_detail", connection);


        
        dr3= cmd3.ExecuteReader();
        
        ddlsub_semester.DataSource = dr3;
        
        if (dr3.HasRows)
        {
            while (dr3.Read())
            {
                for (int i = 0; i < dr3.GetInt32(0); i++)
                {

                    ddlsub_semester.Items.Add(new ListItem((i+1).ToString()));


                }

            }

        }

        oda4 = new OdbcDataAdapter(cmd5);
        ds4 = new DataSet();
        oda4.Fill(ds4, "subject_detail");

        oda3 = new OdbcDataAdapter(cmd4);
        ds3 = new DataSet();
        oda3.Fill(ds3, "subject_detail");

        oda2 = new OdbcDataAdapter(cmd2);
        ds2 = new DataSet();
        oda2.Fill(ds2, "course_detail"); 

        
        oda1 = new OdbcDataAdapter(cmd1);
        ds1 = new DataSet();
        oda1.Fill(ds1, "course_detail");

        oda = new OdbcDataAdapter(cmd);
        ds = new DataSet();
        oda.Fill(ds,"subject_detail");
        
        txtsub_name.Value = ds.Tables[0].Rows[0][1].ToString();
        ddlsub_coursename.Items.Insert(0, ds1.Tables[0].Rows[0][0].ToString());
        ddlsub_semester.Items.Insert(0, ds.Tables[0].Rows[0][3].ToString());
        ddlsub_type.Items.Insert(0, ds.Tables[0].Rows[0][4].ToString());
        ddlsub_credit.Items.Insert(0, ds.Tables[0].Rows[0][5].ToString());


        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
        {
            ddlsub_coursename.Items.Insert(i+1, ds2.Tables[0].Rows[i][0].ToString());
        }

        for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
        {
            ddlsub_type.Items.Insert(i +1, ds3.Tables[0].Rows[i][0].ToString());
        }

        for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
        {
            ddlsub_credit.Items.Insert(i + 1, ds4.Tables[0].Rows[i][0].ToString());
        }
    }
    protected void btnClear_Click(object sender, System.EventArgs e)
    {
        txtsub_name.Value = "";
        ddlsub_coursename.Items.Clear();
        ddlsub_credit.Items.Clear();
        ddlsub_semester.Items.Clear();
        ddlsub_type.Items.Clear();
        
    }
}