<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="UI.admin.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>�ޱ���ҳ</title>
<link rel="stylesheet" href="skin/css/base.css" type="text/css" />
<link rel="stylesheet" href="skin/css/menu.css" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<script language='javascript'>var curopenItem = '1';</script>
<script language="javascript" type="text/javascript" src="skin/js/frame/menu.js"></script>
<base target="main" />
</head>
<body target="main">
    <form id="form1" runat="server">
    <div>
    <table width='99%' height="100%" border='0' cellspacing='0' cellpadding='0'>
  <tr>
    <td style='padding-left:3px;padding-top:8px' valign="top">
	<!-- Item 1 Strat -->
      <dl class='bitem'>
        <dt onclick='showHide("items1_1")' ><b>ϵͳ����</b></dt>
        <dd style='display:block' class='sitem' id='items1_1'>
          <ul class='sitemu'>
            <li><a href='admininfo.aspx?action=Add' target='main'>ϵͳ�˺Ź���</a></li>                     
          </ul>
        </dd>
      </dl>
      
      <dl class='bitem'>
        <dt onclick='showHide("items4_1")'><b>������Ϣ����</b></dt>
        <dd style='display:block' class='sitem' id='items4_1'>
          <ul class='sitemu'>
            <li><a href='GerenInfo.aspx' target='main'>�����б�</a></li>
            <li><a href='GerenInfoAdd.aspx?action=Add' target='main'>��Ӹ�����Ϣ</a></li> 
          </ul>
        </dd>
      </dl>
      
       <dl class='bitem'>
        <dt onclick='showHide("items4_6")'><b>��ͥ��Ϣ����</b></dt>
        <dd style='display:block' class='sitem' id='items4_6'>
          <ul class='sitemu'>
            <li><a href='JT1.aspx?action=Add' target='main'>��ͥ��Ϣ</a></li> 
           
          </ul>
        </dd>
      </dl>
	  </td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
