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

public partial class StudentWiseReport : System.Web.UI.Page
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
        lblloginname.Text = Session["name"] + "";
        
        connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
    }
}