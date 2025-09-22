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
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblNombC" runat="server" Text=" "></asp:Label>
            <asp:Label ID="lblApellC" runat="server" Text=" "></asp:Label>
            <asp:Label ID="lblTelC" runat="server" Text=" "></asp:Label>
            <asp:GridView ID="dgvBuscar" runat="server"></asp:GridView>

            <asp:Label ID="lblFecha" runat="server" Text="Fecha De Viaje" Visible="false"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server" Visible="false"></asp:TextBox>
            <asp:Label ID="lblOrigen" runat="server" Text="Origen" Visible="false"></asp:Label>
            <asp:TextBox ID="txtOrigen" runat="server" Visible="false"></asp:TextBox>
            <asp:Label ID="lblDestino" runat="server" Text="Destino" Visible="false"></asp:Label>
            <asp:TextBox ID="txtDestino" runat="server" Visible="false"></asp:TextBox>
            <asp:Label ID="lblValor" runat="server" Text="Valor Tiquete" Visible="false"></asp:Label>
            <asp:TextBox ID="txtValor" runat="server" Visible="false"></asp:TextBox>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Venta" Visible="false" OnClick="btnRegistrar_Click"/>
            <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" enable="false"/>
            <asp:Label ID="lblExito" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
