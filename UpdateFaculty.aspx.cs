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

public partial class UpdateFaculty : System.Web.UI.Page
{
    OdbcConnection connection;
    OdbcCommand cmd, cmd1, cmd2;
    OdbcDataAdapter oda, oda1, oda2;
    DataSet ds, ds1, ds2;
    OdbcDataReader dr;
    String stat;
    DateTime dt;
    byte[] datasize = null;
    WebClient client = new WebClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Session["name"] + "";
        msger.Visible = false;
        msgri.Visible = false;
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        cmd = new OdbcCommand("select fac_id from faculty_detail", connection);
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
            ddfacid.DataSource = dr;
            ddfacid.DataValueField = "fac_id";
            ddfacid.DataTextField = "fac_id";
            ddfacid.DataBind();
            ddfacid.Items.Insert(0, "Select");

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new OdbcCommand("update faculty_detail set fname='" + txtfac_fname.Value + "',mname='" + txtfac_mname.Value + "',lname='" + txtfac_lname.Value +"',cont_no='"+txtfac_contno.Value + "',pwd='" + txtfac_password.Value +"',role='"+txtfac_role.Value + "' where fac_id='" + ddfacid.SelectedItem.Value + "'", connection);
        cmd.ExecuteNonQuery();
        if (cmd.ExecuteNonQuery() > 0)
        {
            msgri.Visible = true;

            lblok.Text = "Record updated succesfully";
        }
        else
        {
            lblerror.Text = "Record not updated";
        }
    }



    protected void ddfacid_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        cmd = new OdbcCommand("select * from faculty_detail where fac_id='" + ddfacid.SelectedItem.Value + "'", connection);
        oda = new OdbcDataAdapter(cmd);
        ds = new DataSet();
        oda.Fill(ds, "faculty_detail");

        txtfac_fname.Value = ds.Tables[0].Rows[0][1].ToString();
        txtfac_mname.Value = ds.Tables[0].Rows[0][2].ToString();
        txtfac_lname.Value = ds.Tables[0].Rows[0][3].ToString();
        txtfac_contno.Value = ds.Tables[0].Rows[0][4].ToString();
       
        txtfac_password.Value = ds.Tables[0].Rows[0][5].ToString();
        txtfac_role.Value = ds.Tables[0].Rows[0][6].ToString();

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
}