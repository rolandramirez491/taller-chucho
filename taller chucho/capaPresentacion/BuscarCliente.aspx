<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarCliente.aspx.cs" Inherits="capaPresentacion.BuscarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="Identificacion"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Cliente" OnClick="btnBuscar_Click" />
            <asp:Label ID="lblNombC" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblApellC" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblTelC" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
