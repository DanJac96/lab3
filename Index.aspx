<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Laboratorio3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Tipo de Herramienta" runat="server" />
            <asp:DropDownList runat="server" ID="dDLTip">
                <asp:ListItem Text="Herramientas Manuales" />
                <asp:ListItem Text="Herramientas Electricas" />
                <asp:ListItem Text="Herramientas para Jardineria" />
                <asp:ListItem Text="Accesorios para Herramientas" />
            </asp:DropDownList>
            <br />
            <asp:Label Text="Producto" runat="server" /><asp:DropDownList runat="server" ID="dDList">
                <asp:ListItem Text="Tuercas" />
                <asp:ListItem Text="Llaves" />
            </asp:DropDownList>
            <br />
            <asp:Label Text="Cantidad de Herramientas   " runat="server" /><asp:TextBox ID="cantidad" runat="server" />
            <asp:CheckBoxList runat="server" ID="chBox">
                <asp:ListItem Text="Tienda" />
                <asp:ListItem Text="Almacen" />
            </asp:CheckBoxList>
            
            <asp:Button Text="Guardar" id="btGuardar" runat="server" OnClick="btGuardar_Click" />
            <asp:Button Text="Modificar" id="btModificar" runat="server" OnClick="btModificar_Click" />
        </div>
    </form>
</body>
</html>
