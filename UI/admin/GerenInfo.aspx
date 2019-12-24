<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GerenInfo.aspx.cs" Inherits="UI.admin.GerenInfo"  Debug="true"%>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" class="admin_top">
    <tr><td class="auto-style1">个人信息管理-<a href="GerenInfoAdd.aspx?action=Add" class="blue">添加个人信息</a></td></tr>
    <tr><td>按籍贯筛选：<asp:TextBox ID="txtUserNameSearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearchByName" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearchByName_Click" />
                    </td></tr>
    <tr><td>按姓名筛选：<asp:TextBox ID="txtUserXySearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearchByXy" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearchByXy_Click" />
                    &nbsp;
        <asp:Button ID="btnShowAll" runat="server" CssClass="txt" onclick="btnShowAll_Click" 
            Text="显示全部" />
                    </td></tr>
    </table> 
    <table width="98%" class="admin_top">
    <tr><td><asp:GridView ID ="gdvWishList" runat ="server" AutoGenerateColumns="False" 
                    Width="100%" onrowdatabound="gdvWishList_RowDataBound" OnSelectedIndexChanged="gdvWishList_SelectedIndexChanged1" BackColor="White" BorderColor="White" >
                    <Columns>
                     <asp:TemplateField HeaderText="选择" >
               
                <ItemTemplate>
                    <asp:CheckBox ID="ChkSelected"  runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
                         <asp:BoundField HeaderText="编号" ReadOnly="True" />                     
                        <asp:BoundField DataField="姓名" HeaderText="姓名" />
                        <asp:BoundField DataField="字" HeaderText="字" />
                        <asp:BoundField DataField="身份证" HeaderText="身份证" />
                        <asp:BoundField DataField="性别" HeaderText="性别" />
<asp:BoundField DataField="生日" HeaderText="生日" />
                        <asp:BoundField DataField="籍贯" HeaderText="籍贯"/>
                        <asp:BoundField DataField="父家庭编号" HeaderText="父家庭编号"/>
                        <asp:BoundField DataField="母家庭编号" HeaderText="母家庭编号" />
                          <asp:BoundField DataField="子家庭编号" HeaderText="子家庭编号" />
                        <asp:TemplateField HeaderText="编辑"><ItemTemplate ><a href='GerenInfoAdd.aspx?id=<%#Eval("编号") %>&action=Edit' title ="编辑" ><img  alt="编辑" src="images/edit.gif"/></a></ItemTemplate></asp:TemplateField>
                         <asp:TemplateField HeaderText="删除"><ItemTemplate ><a href='sqlDel.aspx?id=<%#Eval("编号") %>&action=DelStudent' title ="删除" onclick="javascript:return confirm('确认删除吗？！')" ><img alt="删除" src="images/action_delete.gif"/></a></ItemTemplate></asp:TemplateField>
                    </Columns>
               
                
                </asp:GridView></td></tr>
    <tr><td bgcolor="White"> <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="全选" 
                        oncheckedchanged="CheckBox1_CheckedChanged" />
&nbsp;
                    <asp:Button ID="btnDelete" runat="server" CssClass="txt" Text="删除"  OnClientClick="javascript:return confirm('确定删除吗？')"
                        onclick="btnDelete_Click" />
&nbsp;
                    <asp:Button ID="btnCancel" runat="server" CssClass="txt" Text="取消" 
                        onclick="btnCancel_Click" />&nbsp;</td></tr>
    </table> 
      <table width="98%" class="admin_top">
     <tr><td>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页" 
            NextPageText="下一页" onpagechanging="AspNetPager1_PageChanging" 
            PageIndexBoxType="DropDownList" PageSize="5" PrevPageText="上一页" 
            ShowMoreButtons="False" ShowPageIndexBox="Always" SubmitButtonText="Go" 
            TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" OnPageChanged="AspNetPager1_PageChanged1">
        </webdiyer:AspNetPager>
        </td></tr>
    </table> 
    </div>
    </form>
</body>
</html>
