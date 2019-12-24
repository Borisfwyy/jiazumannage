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
    public partial class JT1 : System.Web.UI.Page
    {
    
        public SDM.BLL.jiating bll2 = new SDM.BLL.jiating();
        public SDM.Model.jiating model2 = new SDM.Model.jiating();
        protected SDM.Model.jiating CreateModel2()
        {
            model2.Hkszd = TextBox1.Text.Trim();
            model2.Miaoshu =TextBox2.Text.Trim();
            return model2;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                 switch (Request.QueryString["action"].ToString().Trim())
                 {
                     case "add":
                         Button2.Visible = false;
                         Button1.Visible = true;
                         break;
                     case "Edit":
                         Button2.Visible = true;
                         Button1.Visible = false;
                         int id = int.Parse(Request.QueryString["id"]);
                         model2 = bll2.GetModel(id);
                         TextBox1.Text = model2.Hkszd.ToString();
                         TextBox2.Text = model2.Miaoshu.ToString();
                         break;
                    
                 }
                 bind2();
             }
            
        }
        protected void bind2()
        {
            Repeater1.DataSource = bll2.GetAllList();
            Repeater1.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            model2 = CreateModel2();
            model2.Jiating = int.Parse(Request.QueryString["id"].ToString());
            bll2.Update(model2);
            SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
            bind2();//重新刷新数据
        }
        protected void Button1_Click(object sender, EventArgs e)
        {         
            
                bll2.Add(CreateModel2());
                SDM.DAL.ShowInfo.Alert("操作成功!", this.Page);
                bind2();
            
        }

   

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }
        
    }
}
    
