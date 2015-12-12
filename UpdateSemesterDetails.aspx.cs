using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateSemesterDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("IncrementAll.aspx");
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Server.Transfer("DecrementSemester.aspx");
    }
}