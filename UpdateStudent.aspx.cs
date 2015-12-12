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

public partial class UpdateStudent : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd,cmd1,cmd2,cmd3,cmd4,cmd5;
    OdbcDataAdapter oda,oda1,oda2,oda3,oda5;
    DataSet ds,ds1,ds2,ds3,ds5;
    OdbcDataReader dr,dr1,dr2;
    String stat;
    DateTime dt;
    int sem;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
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
        if (!IsPostBack)
        {
            txtstud_courseid.DataSource = dr;
            txtstud_courseid.DataValueField = "course_name";
            txtstud_courseid.DataTextField = "course_name";
           txtstud_courseid.DataBind();
           

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime date = Convert.ToDateTime(Calendar1.SelectedDate.ToShortDateString());
       String dt = date.Date.ToString("yyyy/MM/dd");
           
        cmd = new OdbcCommand("update student_detail set fname='"+txtstud_fname.Value+"',mname='"+txtstud_mname.Value+"',lname='"+txtstud_lname.Value+"',course_id=(select course_id from course_detail where course_name='"+txtstud_courseid.SelectedItem.Value+"'),sem='"+DropDownList1.SelectedItem.Value+"',stud_div='"+DropDownList2.SelectedItem.Value+"',emailid='"+txtstud_emailid.Value+"',s_cont_no='"+txtstud_scontno.Value+"',p_cont_no='"+txtstud_pcontno.Value+"',reg_date='"+dt+"',pwd='"+txtstud_password.Value+"',batch='"+txtstud_batch.Value+"',status='"+txtstud_status.Value+"' where stud_id='" + ddstudid.SelectedItem.Value + "'", connection);
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
    protected void ddstudid_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtstud_courseid.Items.Clear();
           cmd = new OdbcCommand("select * from student_detail where stud_id='"+ddstudid.SelectedItem.Value+"'", connection);

           cmd1 = new OdbcCommand("select course_name from course_detail where course_id=(select course_id from student_detail where stud_id='" + ddstudid.SelectedItem.Value + "')", connection);

           cmd2 = new OdbcCommand("select course_name from course_detail",connection);
            oda = new OdbcDataAdapter(cmd);

            oda1 = new OdbcDataAdapter(cmd1);

            oda2 = new OdbcDataAdapter(cmd2);
            ds1 = new DataSet();
            ds2 = new DataSet();

            oda1.Fill(ds1, "course_detail");
            oda2.Fill(ds2, "course_detail");
            ds = new DataSet();
           oda.Fill(ds,"student_detail");


           txtstud_fname.Value = ds.Tables[0].Rows[0][1].ToString();
           txtstud_mname.Value = ds.Tables[0].Rows[0][2].ToString();
           txtstud_lname.Value = ds.Tables[0].Rows[0][3].ToString();
           txtstud_courseid.Items.Insert (0, ds1.Tables[0].Rows[0][0].ToString());
          
           txtstud_emailid.Value = ds.Tables[0].Rows[0][7].ToString();
           txtstud_scontno.Value = ds.Tables[0].Rows[0][8].ToString();
           txtstud_pcontno.Value = ds.Tables[0].Rows[0][9].ToString();
           DateTime date = Convert.ToDateTime(ds.Tables[0].Rows[0][10].ToString());
           txt_reg_dt.Value=date.Date.ToString("dd/MM/yyyy");
           txtstud_password.Value = ds.Tables[0].Rows[0][11].ToString();
           txtstud_batch.Value = ds.Tables[0].Rows[0][13].ToString();
           txtstud_status.Value=ds.Tables[0].Rows[0][14].ToString();

           for (int i = 0; i <ds2.Tables[0].Rows.Count; i++)
           {
               txtstud_courseid.Items.Insert(i+1,ds2.Tables[0].Rows[i][0].ToString());
           }   

            
            
           

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtstud_fname.Value = "";
        txtstud_mname.Value = "";
        txtstud_lname.Value = "";
        txtstud_batch.Value = "";
        txtstud_courseid.ClearSelection();
        txt_reg_dt.Value = "";
        txtstud_emailid.Value = "";
        txtstud_password.Value = "";
        
        txtstud_scontno.Value = "";
        
        txtstud_status.Value = "";
        txtstud_pcontno.Value = "";
        ddstudid.Items.Clear();
        txtstud_courseid.Items.Clear();
        DropDownList1.Items.Clear();
        DropDownList2.Items.Clear();
        

    }
    protected void txtstud_courseid_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();
        cmd4 = new OdbcCommand("select total_sem from course_detail where course_name='"+txtstud_courseid.SelectedItem.Value+"'", connection);
        dr2 = cmd4.ExecuteReader();
        
        DropDownList1.DataSource = dr2;
        
        if (dr2.HasRows)
        {
            while (dr2.Read())
            {
                for (int i = 0; i < dr2.GetInt32(0); i++)
                {

                    DropDownList1.Items.Insert(i,new ListItem((i + 1).ToString()));


                }

            }

        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        cmd3 = new OdbcCommand("select distinct stud_div from student_detail", connection);
        oda3 = new OdbcDataAdapter(cmd3);
        ds3 = new DataSet();
       
        oda3.Fill(ds3,"student_detail");

        for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
        {
            DropDownList2.Items.Insert(i,ds3.Tables[0].Rows[i][0].ToString());
        }

       
       
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txt_reg_dt.Value = Calendar1.SelectedDate.ToShortDateString();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddstudid.Items.Clear();
        cmd5 = new OdbcCommand("select stud_id from student_detail where course_id=(select course_id from course_detail where course_name='" + txtstud_courseid.SelectedItem.Value + "') and sem='" + DropDownList1.SelectedItem.Value + "' and stud_div='" + DropDownList2.SelectedItem.Value + "'", connection);
        oda5 = new OdbcDataAdapter(cmd5);
        ds5 = new DataSet();
        oda5.Fill(ds5, "student_detail");
        ddstudid.Items.Insert(0, "Select");
        for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
        {
            ddstudid.Items.Insert(i+1, ds5.Tables[0].Rows[i][0].ToString());
        }
    }
}