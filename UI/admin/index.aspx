<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UI.admin.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server" >
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link href="css/body.css" rel="stylesheet" />
    <title>ѧ���Ƽ���Ʒչʾƽ̨</title>
</head>

<frameset rows="60,*,150" cols="*" frameborder="no" border="0" framespacing="0">
  <frame src="top.aspx" name="topFrame" scrolling="no">
  <frameset cols="180,*" name="btFrame" frameborder="NO" border="0" framespacing="0">
    <frame src="menu.aspx" noresize name="menu" scrolling="yes">
    <frame src="main.aspx" noresize name="main" scrolling="yes">
  </frameset>
  <frame src="foot.aspx" name="footFrame" scrolling="no">
</frameset>
<noframes>
	<body class="noframebody">�����������֧�ֿ�ܣ�</body>
</noframes>
</html>
