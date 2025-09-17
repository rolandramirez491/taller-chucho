<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionVentas.aspx.cs" Inherits="capaPresentacion.GestionVentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="txtId">

            </asp:Label><asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:Label ID="lblFecha" runat="server" Text="Fecha De Viaje"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <asp:Label ID="lblOrigen" runat="server" Text="Origen"></asp:Label>
            <asp:TextBox ID="txtOrigen" runat="server"></asp:TextBox>
            <asp:Label ID="lblDestino" runat="server" Text="Destino"></asp:Label>
            <asp:TextBox ID="txtDestino" runat="server"></asp:TextBox>
            <asp:Label ID="lblValor" runat="server" Text="Valor Del Tiquete">

            </asp:Label><asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Venta" />
        </div>
    </form>
</body>
</html>
