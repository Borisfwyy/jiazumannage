<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="UI.admin.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server" >
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link href="css/body.css" rel="stylesheet" />
    <title>学生科技作品展示平台</title>
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
	<body class="noframebody">您的浏览器不支持框架！</body>
</noframes>
</html>
