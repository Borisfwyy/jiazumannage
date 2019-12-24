<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JT1.aspx.cs" Inherits="UI.admin.JT1" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: small;
        }
    </style>
</head>
<body bgcolor="#CCFFFF">
    <form id="form1" runat="server">
    <div>
        <table width="98%" class="admin_top">
    <tr><td class="auto-style3"><span class="auto-style1">家庭编辑--</span><a href ="JT1.aspx?action=add" class="blue"><span class="auto-style1">添加家庭</span></a></td></tr>

        

      <tr><td><span class="auto-style1">户口所在地</span>  <asp:TextBox ID="TextBox1" runat="server" CssClass="txt" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td></tr>

    
       <tr><td><span class="auto-style1">&nbsp;描&nbsp;述&nbsp;</span> <asp:TextBox ID="TextBox2" runat="server" CssClass="txt" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>&nbsp;<asp:Button ID="Button1" runat="server" CssClass="txt" OnClick="Button1_Click"  Text="添加" Width="66px" />&nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="txt" Text="修改"  onclick="Button2_Click" Width="66px" /> &nbsp;&nbsp;
           </td></tr>
    </table>
     <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
        
        <HeaderTemplate>
        
       <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
  <tr>
    <td bgcolor="#66CCFF"><div align="center" class="STYLE6">家庭编号</div></td>
    <td bgcolor="#66CCFF"><div align="center" class="STYLE6">户口所在地</div></td>
    <td bgcolor="#66CCFF"><div align="center" class="STYLE6">描述</div></td>
    <td bgcolor="#66CCFF"><div align="center" class="STYLE6">修改</div></td>
    <td bgcolor="#66CCFF"><div align="center" class="STYLE6">删除</div></td>
  </tr>
  
</HeaderTemplate>

<ItemTemplate>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"><%# Container.ItemIndex + 1%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("户口所在地")%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("描述")%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='JT1.aspx?id=<%#Eval("家庭编号")%>&action=Edit' class="blue"><img alt="Edit" src="images/edit.gif"/></a></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='sqlDel.aspx?id=<%#Eval("家庭编号") %>&action=DelJia'><img alt="Delete" src="images/delete.gif"/></a></div></td>
  </tr>
</ItemTemplate>
<FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
        </div>
    </form>
</body>
</html>
