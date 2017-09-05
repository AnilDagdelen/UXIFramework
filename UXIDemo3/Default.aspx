<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UXIDemo3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<title>Facebook Style Home Page Design - demo by w3lessons.info</title>
<link rel="stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<div class="login">
<!-- header starts here -->
<div id="facebook-Bar">
  <div id="facebook-Frame">
    <div id="logo"> <a href="http://w3lessons.info">Facebook.com</a> </div>
    
         
        <div id="header-main-right">
          <div id="header-main-right-nav"> 
          <table border="0" style="border:none">
            <tr>
              <td ><input type="text" tabindex="1"  id="email" placeholder="Email or Phone" name="email" class="inputtext radius1" value=""/></td>
              <td ><input type="password" tabindex="2" id="pass" placeholder="Password" name="pass" class="inputtext radius1" /></td>
              <td ><input type="submit" class="fbbutton" name="login" value="Login" /></td>
            </tr>
            <tr>
            <td><label><input id="persist_box" type="checkbox" style="font-size:14px;" name="persistent" value="1" checked="checked"/><span style="color:#ccc;">Keep me logged in</span></label>
            </td>
            <td><label><a style="color:#ccc; font-size:14px; text-decoration:none">forgot your password?</a></label></td>
            </tr>
          </table> 
      </div>
          </div>
      </div> 
</div>
<!-- header ends here --> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 
    <div class="loginbox radius" runat="server">

        <img src="post.PNG" width="500" height="700" />
    </div><!--loginbox--> 


</div>

    </form>
</body>
</html>
