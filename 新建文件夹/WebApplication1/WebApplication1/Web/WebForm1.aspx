<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link  href="../css/bootstrap.min.css" rel="stylesheet" />
     <script type="text/javascript" src="../js/jquery-2.0.0.min.js" ></script>
    <script type="text/javascript" src="../js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
<div class="container">
	<div class="row">
		<div class="span12">
			<p>
				<span class="label badge-warning">哈哈哈哈</span>
                <button type="button" class="btn btn-primary " runat="server" id ="btnAdd" onserverclick="btnAdd_ServerClick" >Add</button>
			</p>
		</div>
	</div>
</div>
    </form>
</body>
</html>
