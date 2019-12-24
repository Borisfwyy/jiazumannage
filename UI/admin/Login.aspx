<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.admin.Login" %>

<!DOCTYPE HTML>
<html>
    
    <head>
        <TITLE>管理员登录</TITLE>
        <link href="css.css" type="text/css" rel="Stylesheet" />
        <meta name="renderer" content="webkit">
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
        <meta name="generator" content="dede58 5.3.9" data-variable="" />
        <meta name="keywords" content="管理" />
        <meta name="description" content="家族管理系统" /> 

        <link rel="stylesheet" href="css/3af1bf1fa0061831.css">
 
        
        <style type="text/css">
            .auto-style1 {
                width: 88px;
                height: 71px;
            }
            .navbar-header {
                height: 60px;
            }
            .title_div{
                width: 100%;
                height: 30px; 
                line-height: 30px;
                text-align: center;
                background-color:rgba(220,38,38,0.2);
            }
            
        </style>
 
        
    </head>
    
    <body>
        <form id="form1" runat="server">
        <nav class="navbar navbar-default met-nav " role="navigation">
            <div class="container">
                <div class="row">
                    <div class="navbar-header">
                        
                        
                        <img alt="" class="auto-style1" src="picture/titlewang.jpg" /></div>
                   
                </div>
            </div>
        </nav>
          
        
         <div class="met-banner"  >
            <div class="carousel slide" id="met-banner-slide" data-ride="carousel">                                              
                <div class="carousel-inner carousel-height" role="listbox">
                    <div class="item active"  >
                        <picture>
                            <source srcset="picture/LoginQDnew.jpg"  style="width: 1920px; height:1080px" />
                            
                            <img class="cover-image overlay-scale" srcset="images/1470992331.jpg"
                            alt="" />
                        </picture>
                        <div class="carousel-caption p-5">                           
                            <h3 class="animation-slide-top animation-delay-300" style="color:#ffffff;">
                                家族人员管理系统
                            </h3>
                            <br />
                           <tr>
                              <h3 class="animation-slide-top animation-delay-300" style="color:#ffffff;" ><span class="STYLE3">账号</span></h3>
                              <td width="79%" height="50">
                                 <asp:TextBox ID="txtUserName" runat="server" style="border:2px solid #ffffff;color:#333300" class="animation-slide-top animation-delay-300"></asp:TextBox>
                              </td>
                           </tr>
                            <br />
                           <tr>
                              <h3 class="animation-slide-top animation-delay-300" style="color:#ffffff;" ><span class="STYLE3">密码</span></h3>
                              <td width="79%" height="50">
                                <asp:TextBox ID="txtUserPass" runat="server" style="border:2px solid #ffffff;color:#333300" class="animation-slide-top animation-delay-300"></asp:TextBox>
                              </td>
                           </tr>
                            <br>
                           <tr>
                              <td height="30">&nbsp;</td>
                              <td height="30">
                                  <asp:Button ID="btnLogin" runat="server" Text="登录" style="border:2px solid #ffffff;color:#333300" class="animation-slide-top animation-delay-300" 
                                    onclick="btnLogin_Click" Height="40px" Width="90px"/>
                                  &nbsp;&nbsp;
                                  <asp:Button ID="btnClean" runat="server" Text="重置" style="border:2px solid #ffffff;color:#333300" class="animation-slide-top animation-delay-300" 
                                    onclick="btnClean_Click" Height="40px" Width="90px"/>                                  
                              </td>
                           </tr>
                            
                        </div>
                    </div>                                    
                </div>
               
            </div>
        </div>
       
        
        
    </form>
    </body>

</html>