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
    public partial class GerenInfoAdd : System.Web.UI.Page
    {
        public SDM.BLL.GerenInfo bll = new SDM.BLL.GerenInfo();
        public SDM.Model.GerenInfo model = new SDM.Model.GerenInfo();


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void EditLoadData()
        {
            int id = int.Parse(Request.QueryString["id"]);
            model = bll.GetModel(id);
            TextBox1.Text = model.Ffbianhao.ToString();
            TextBox2.Text = model.Mfbianhao.ToString();
            TextBox3.Text = model.Ffbianhao.ToString();
            TextBox4.Text = model.shengri.ToString();
            zi.Text = model.Zi.ToString();
            name.Text = model.Name.ToString();
            jiguan.Text = model.Jiguan.ToString();
            sfz.Text = model.Sfz.ToString();
            DDLSex.Text = model.Sex.ToString();
         
        }
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (sfz.Text.Trim() == "")
            {
                SDM.DAL.ShowInfo.Alert("请输入家庭成员编号！", this.Page);
                return;
            }
            else if (bll.Exists(sfz.Text.Trim()))
            {
                SDM.DAL.ShowInfo.Alert("对不起，此身份证号已被添加，请更换！！", this.Page);
                sfz.Focus();
                return;
            }
            else
            {
                SDM.DAL.ShowInfo.Alert("身份证号可用！", this.Page);
                return;
            }
        }
        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (sfz.Text.Trim() == "" || jiguan.Text.Trim() == "" || name.Text.Trim() == "" )
            {
                SDM.DAL.ShowInfo.Alert("身份证号||籍贯||姓名信息必填！！", this.Page);
                return;
            }
            else if (bll.Exists(sfz.Text.Trim()))//防止用户没有检验学号直接添加
            {
                SDM.DAL.ShowInfo.Alert("对不起，此身份证号已被添加，请更换！！", this.Page);
                sfz.Focus();
            }
            else
            {
                //执行添加学生信息
                model = CreateModel();
                int count = bll.Add(model);
                SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
                sfz.Text = "";
                name.Text = "";
                jiguan.Text = "";
                zi.Text = "";
                TextBox4.Text = "";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            model = CreateModel();
            model.Bianhao = int.Parse(Request.QueryString["id"]);
            
            bll.Update(model);
            SDM.DAL.ShowInfo.AlertAndRedirect("操作成功！", "GerenInfo.aspx", this.Page);
        }

        protected SDM.Model.GerenInfo CreateModel()
        {
            model.Ffbianhao = TextBox1.Text.Trim();
            model.Jiguan = jiguan.Text.Trim();
            model.Mfbianhao = TextBox2.Text.Trim();
            model.Sex = DDLSex.SelectedItem.Text.Trim();
            model.Name = name.Text.Trim();
            model.Zfbianhao =TextBox3.Text.Trim();
            model.Zi = zi.Text.Trim();
            model.Sfz = sfz.Text.Trim();
            model.shengri = TextBox4.Text.Trim();
           
            return model;
        }

        protected void txtUserNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtUserBj_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DDLSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void jiguan_TextChanged(object sender, EventArgs e)
        {

        }

        protected void bianhao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
