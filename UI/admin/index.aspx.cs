﻿using System;
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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] == null)
                {
                    //下载于www.51aspx.com
                    // RA.Common.Jscript.AlertAndRedirect("登录超时,请重新登录！", "login.aspx", this.Page);
                    Response.Write("<script>alert('登录超时,请重新登录！');parent.location.href='./login.aspx'</script>");
                }

            }

        }
    }
}
