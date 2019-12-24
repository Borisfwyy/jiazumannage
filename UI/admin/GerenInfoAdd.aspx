<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GerenInfoAdd.aspx.cs" Inherits="UI.admin.GerenInfoAdd" uiCulture="aa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        </style>
</head>
<body style="int">
    <form id="form1" runat="server">
    <div>
     <table width="98%" class="admin_top">
    <tr><td>添加个人信息-<a href="GerenInfo.aspx" class="blue">个人信息管理</a></td></tr>
    </table> 
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#EEEED1">
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" class="admin_top">个人信息编辑</td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">身份证</td>
    <td width="811" bgcolor="#FFFFFF">
        <asp:TextBox ID="sfz" runat="server" CssClass="txt"></asp:TextBox>
        &nbsp;<asp:Button ID="btnCheck" runat="server" CssClass="txt" Text="检查是否重复" 
            onclick="btnCheck_Click" />
                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">性别</div></td>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
        <asp:DropDownList ID="DDLSex" runat="server" CssClass="txt" >
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList>
        </div></td>
  </tr>
    
    

  
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">姓名</div></td>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
        <asp:TextBox ID="name" runat="server" CssClass="txt" Width="166px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">籍贯</div></td>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
        <asp:TextBox ID="jiguan" runat="server" CssClass="txt" Width="167px" OnTextChanged="jiguan_TextChanged"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">字</div></td>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
        <asp:TextBox ID="zi" runat="server" CssClass="txt" Width="165px" ></asp:TextBox>
        </div></td>
  </tr>
              <tr>
    <td bgcolor="#FFFFFF"><div align="center">生日</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="TextBox4" runat="server" CssClass="txt" Width="165px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        </div></td>
  </tr>
        <tr>
    <td bgcolor="#FFFFFF"><div align="center">父家庭编号</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="txt" Width="165px" ></asp:TextBox>
        </div></td>
  </tr>
        <tr>
    <td bgcolor="#FFFFFF"><div align="center">母家庭编号</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="TextBox2" runat="server" CssClass="txt" Width="165px" ></asp:TextBox>
        </div></td>
  </tr>
        <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">子家庭编号</div></td>
     <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
        <asp:TextBox ID="TextBox3" runat="server" CssClass="txt" Width="165px" ></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"></div></td>
    <td bgcolor="#FFFFFF">
        <asp:Button ID="btnOk" runat="server" CssClass="txt" Text="添加" 
            onclick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" CssClass="txt" Text="修改" 
            onclick="btnEdit_Click" />
&nbsp;
        </td>
  </tr>
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" class="admin_top STYLE2">说明：为了系统便于统一管理，请按照“XX省XX市XX区”正确输入。</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
