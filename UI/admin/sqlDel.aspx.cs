using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace UI.admin
{
    public partial class sqlDel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //从查询字符串中读取需要删除的id值
            int id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                //根据传入的action值判断需要进行的操作
                switch (Request.QueryString["action"].ToString().Trim())
                {
                    case "DelStudent":      //删除个人信息
                        SDM.BLL.GerenInfo bllStudent = new SDM.BLL.GerenInfo();
                        bllStudent.Delete(id);
                        SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "GerenInfo.aspx", this.Page);
                        break;
                    case "DelAdmin":        //删除管理员帐号
                        SDM.BLL.AdminInfo bllAdminInfo = new SDM.BLL.AdminInfo();
                        bllAdminInfo.Delete(id);
                        SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "AdminInfo.aspx?action=add", this.Page);
                        break;
                    case "DelJia":        //删除管理员帐号
                        SDM.BLL.jiating bllJiaInfo = new SDM.BLL.jiating();
                        bllJiaInfo.Delete(id);
                        SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "JT1.aspx?action=add", this.Page);
                        break;
                   
                }
            }
        }
    }
}
