using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace UI.admin
{
    public partial class top : System.Web.UI.Page
    {
        public string userid = "";
        public string strUsername = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                // RA.Common.Jscript.AlertAndRedirect("登录超时,请重新登录！", "login.aspx", this.Page);
                Response.Write("<script>alert('登录超时,请重新登录！');parent.location.href='./login.aspx'</script>");
            }
            else
            {
                userid = Session["userid"].ToString();
                strUsername = Session["username"].ToString();
            }
        }
        protected void btnLoginOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Write("<script>alert('注销成功！');parent.location.href='./index.aspx'</script>");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
            Response.Write("<script>alert('功能未开放...')");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>top.location.reload();</script>");
        }
    }
}
