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

public partial class RegistrationCompleteFinal : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd,cmd1,cmd2,cmd3;
    OdbcDataAdapter odbcadap=new OdbcDataAdapter(),odbcadap1;
    DataSet ds,ds1;
    String txtstud_courseid;
    OdbcDataReader dr1,dr;
    int sem;
    WebClient client = new WebClient();
    byte[] datasize = null;
    protected void Form2_Load(object sender,EventArgs e)
    {
        btnClear_Click(sender,e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;


        
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
       
        cmd1 = new OdbcCommand("select course_name from course_detail", connection);
        try
        {
            connection.Open();
            datasize = client.DownloadData("http://www.google.com");
        }



        catch (Exception ex)
        {

            Response.Redirect("InternetConnectionErrorFaculty.aspx");
        }
        dr = cmd1.ExecuteReader();
        
        
        if (!IsPostBack)
        {
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "course_name";
            DropDownList1.DataTextField = "course_name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
        }
       

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        //cmd = new OdbcCommand("Select * from student_detail", connection);

        odbcadap.SelectCommand = new OdbcCommand("Select * from student_detail where stud_id='" + txtstud_id1.Value + "'", connection);

        ds = new DataSet();

       

        odbcadap.Fill(ds,"student_detail");

        if (ds.Tables[0].Rows.Count == 0)
        {
           

            cmd2 = new OdbcCommand("select course_id from course_detail where course_name='" + DropDownList1.SelectedItem.Value + "'", connection);
            odbcadap1 = new OdbcDataAdapter(cmd2);
            ds1 = new DataSet();
            odbcadap1.Fill(ds1, "course_detail");

             txtstud_courseid = ds1.Tables[0].Rows[0][0].ToString();
             DateTime date = Convert.ToDateTime(Calendar1.SelectedDate.ToShortDateString());
             String dt = date.Date.ToString("yyyy/MM/dd");

             cmd = new OdbcCommand("INSERT INTO student_detail(stud_id,fname,mname,lname,course_id,sem,stud_div,emailid,s_cont_no,p_cont_no,reg_date,pwd,batch,status) VALUES('" + txtstud_id1.Value + "','" + txtstud_fname.Value + "','" + txtstud_mname.Value + "','" + txtstud_lname.Value + "','" + txtstud_courseid + "','" + DropDownList2.SelectedItem.Value + "','" + txtstud_div.Value + "','" + txtstud_emailid.Value + "','" + txtstud_scontno.Value + "','" + txtstud_pcontno.Value + "','" + dt+ "','" + txtstud_password.Value + "','" + txtstud_batch.Value + "','" + txtstud_status.Value + "')", connection);
            cmd.ExecuteNonQuery();
            msgri.Visible = true;
            lblok.Text = "Record inserted succesfully";
            
        }
        else {
            msger.Visible = true;
            lblerror.Text = "Record already exists";
        }

        
        connection.Close();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtstud_id1.Value = "";
        txtstud_fname.Value = "";
        txtstud_mname.Value = "";
        txtstud_lname.Value = "";
        txtstud_batch.Value = "";
        txtstud_courseid= "";
        txtstud_div.Value = "";
        txtstud_emailid.Value = "";
        txtstud_password.Value = "";
        txtstud_pcontno.Value = "";
       
        txtstud_scontno.Value = "";
      


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        cmd3 = new OdbcCommand("select total_sem from course_detail where course_name='" + DropDownList1.SelectedItem.Value + "'", connection);
        dr1 = cmd3.ExecuteReader();
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
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        
    }
}