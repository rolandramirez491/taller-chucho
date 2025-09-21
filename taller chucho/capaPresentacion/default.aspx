<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="capaPresentacion._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>taller de chucho</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="Id" runat="server" Text="Identificacion"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Label ID="lblNomb" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNomb" runat="server"></asp:TextBox>
            <asp:Label ID="lblApell" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApell" runat="server"></asp:TextBox>
            <asp:Label ID="lblTel" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>
