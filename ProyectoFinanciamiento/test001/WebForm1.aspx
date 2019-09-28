<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test001.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario:
            <asp:TextBox ID="TXTUser" runat="server"></asp:TextBox>
        </div>
        Contraseña:<asp:TextBox ID="TXTPass" runat="server"></asp:TextBox>
        <asp:Button ID="BTNIngresar" runat="server" OnClick="BTNIngresar_Click" Text="Ingresar" />
    </form>
</body>
</html>
