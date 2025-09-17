<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarVentas.aspx.cs" Inherits="capaPresentacion.ListarVentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnListar" runat="server" Text="Listar ventas" />
            <asp:GridView ID="dgvListaVentas" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
