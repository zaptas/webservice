using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WCFClient
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyFirstService.IindexClient onj = new MyFirstService.IindexClient();
            onj.Open();
            Response.Write(onj.Getmessage(" Sohel khan"));
            onj.Close();
        }
    }
}