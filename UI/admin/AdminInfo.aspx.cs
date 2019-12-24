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
    public partial class Jiating : System.Web.UI.Page
    {
        public SDM.BLL.AdminInfo bll = new SDM.BLL.AdminInfo();
        public SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
        protected SDM.Model.AdminInfo CreateModel()
        {
            model.AdminName = txtUserName.Text.Trim();
            model.AdminPass = txtPwd.Text.Trim();
            return model;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                switch (Request.QueryString["action"].ToString().Trim())
                {
                    case "Add":
                        btnEdit.Visible = false;
                        btnAdd.Visible = true;
                        break;
                    case "Edit":
                        btnEdit.Visible = true;
                        btnAdd.Visible = false;
                        int id = int.Parse(Request.QueryString["id"]);
                        model = bll.GetModel(id);
                        txtUserName.Text = model.AdminName.ToString();
                        txtPwd.Text = model.AdminPass.ToString();
                        break;
                }
                bind();
            }
        }
        protected void bind()
        {
            Repeater1.DataSource = bll.GetAllList();
            Repeater1.DataBind();
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            model = CreateModel();
            model.AdminID = int.Parse(Request.QueryString["id"].ToString());
            bll.Update(model);
            SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
            bind();//重新刷新数据
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPwd.Text == "")
            {
                SDM.DAL.ShowInfo.Alert("账号和密码不能为空！", this.Page);
                return;
            }
            else
            {
                bll.Add(CreateModel());
                SDM.DAL.ShowInfo.Alert("操作成功!", this.Page);
                bind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

