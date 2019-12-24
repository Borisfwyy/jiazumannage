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
using System.Data.SqlClient;

namespace UI.admin
{
    public partial class GerenInfo : System.Web.UI.Page
    {
        public SDM.BLL.GerenInfo bll = new SDM.BLL.GerenInfo();
        public SDM.Model.GerenInfo model = new SDM.Model.GerenInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        public void LoadData()
        {
            gdvWishList.DataSource = bll.GetListByPage("1=1", "编号 DESC", AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1, AspNetPager1.PageSize * AspNetPager1.CurrentPageIndex);
            gdvWishList.DataKeyNames = new string[] { "编号" };
            gdvWishList.DataBind();
            AspNetPager1.RecordCount = bll.GetRecordCount("1=1");
        }

        protected void gdvWishList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex != -1)
            {
                int id = e.Row.RowIndex + 1;
                e.Row.Cells[1].Text = id.ToString();
            }
        }
        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");
                if (CheckBox1.Checked == true)
                {
                    cbox.Checked = true;
                }
                else
                {
                    cbox.Checked = false;
                }
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");
                if (cbox.Checked == true)
                {
                    bll.Delete(Convert.ToInt32(gdvWishList.DataKeys[i].Value));
                }
            }
            LoadData();
            this.CheckBox1.Checked = false;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.CheckBox1.Checked = false;
            for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");

                cbox.Checked = false;
            }
        }
        protected void btnSearchByName_Click(object sender, EventArgs e)
        {
            gdvWishList.DataSource = bll.GetStudentListByUserXy(txtUserNameSearch.Text.Trim());//籍贯
            gdvWishList.DataBind();
        }
        protected void btnSearchByXy_Click(object sender, EventArgs e)
        {
            gdvWishList.DataSource = bll.GetStudentListByUserName(txtUserXySearch.Text.Trim());//姓名
            gdvWishList.DataBind();
        }
        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

       

        protected void AspNetPager1_PageChanged1(object sender, EventArgs e)
        {

        }

        protected void gdvWishList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gdvWishList_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        
    }
}
