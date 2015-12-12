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
using System.Data.SqlClient;
using System.Configuration;

public partial class ReportDisplayFaculty : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1, cmd2,cmd3;
    OdbcDataAdapter oda, oda1, oda2,oda3;
    DataSet ds, ds1, ds2,ds3;
    OdbcDataReader dr;
    String stat;
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
        if (!IsPostBack)
        {
            String stud_id = Session["stud_id"].ToString();
            cmd = new OdbcCommand("select su.sub_id, case when su.credit>4 then 'Practical' else 'Theory' end as lec_type from subject_detail su,student_detail st where (su.course_id=st.course_id and st.sem=su.sem) and st.stud_id='" + stud_id + "'", connection);
            //cmd.ExecuteNonQuery();post back check kari jone.. means if (!ispostback ) vadi condition check kari jone am
            oda = new OdbcDataAdapter(cmd);
            ds = new DataSet();
            ds1 = new DataSet();
            oda.Fill(ds, "student_detail");
            int[] y = new int[ds.Tables[0].Rows.Count - 1];
            //Response.Write("Total sub:" + ds.Tables[0].Rows.Count); i think it iwait
            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                cmd2 = new OdbcCommand("select ((select count(stud_id) from attendance_transaction where stud_id='" + stud_id + "' and status=1 and att_id in (select att_id from attendance_detail where sub_id='" + ds.Tables[0].Rows[i][0].ToString() + "' and lec_type='" + ds.Tables[0].Rows[i][1].ToString() + "'))/count(stud_id))*100 from attendance_transaction where stud_id='" + stud_id + "' and att_id in (select att_id from attendance_detail where sub_id='" + ds.Tables[0].Rows[i][0].ToString() + "' and lec_type='" + ds.Tables[0].Rows[i][1].ToString() + "')", connection);
                oda1 = new OdbcDataAdapter(cmd2);

                oda1.Fill(ds1);
                try
                {
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        y[i] = Convert.ToInt32(ds1.Tables[0].Rows[i][i]);
                    }
                }
                catch (InvalidCastException ie)
                {
                }
            }
            //Chart1.Visible = true;
            string[] x = new string[ds1.Tables[0].Rows.Count];

            //DBNull d=null;

            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {


                try
                {
                    // y[i] = Convert.ToInt32(ds1.Tables[0].Rows[i][i]);
                    x[i] = (ds.Tables[0].Rows[i][0].ToString() + "\n" + ds.Tables[0].Rows[i][1].ToString());
                }
                catch (InvalidCastException ie)
                {
                    y[i] = Convert.ToInt32(ds1.Tables[0].Rows[i][i]);
                    x[i] = (ds.Tables[0].Rows[i][0].ToString() + "\n" + ds.Tables[0].Rows[i][1].ToString());
                }

            }
            Chart1.Series[0].Points.DataBindXY(x, y);

            Chart1.Series[0].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Column;


            Chart1.Legends[0].Enabled = true;
            cmd3 = new OdbcCommand("select fname,mname,lname from student_detail where stud_id='" + Session["stud_id"].ToString() + "'", connection);
            oda3 = new OdbcDataAdapter(cmd3);
            ds3 = new DataSet();
            oda3.Fill(ds3, "student_detail");
            lbl1.Text = "Report of " + " " + ds3.Tables[0].Rows[0][0].ToString() + " " + ds3.Tables[0].Rows[0][1].ToString() + " " + ds3.Tables[0].Rows[0][2].ToString();
        }

    }
    protected void Chart1_Load(object sender, EventArgs e)
    {
        //String course=Session["course"].ToString();
        //int semester=Convert.ToInt32(Session["semester"].ToString());
        //String div=Session["division"].ToString();


    }
}