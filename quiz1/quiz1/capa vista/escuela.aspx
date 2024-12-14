<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="escuela.aspx.cs" Inherits="quiz1.capa_vista.escuela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 469px">
            <h2>TABLA ESCUELA</h2>
            <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            <br />
            <br />
EscuelaID:
<asp:TextBox ID="ID" type="number" runat="server"></asp:TextBox>
<br />
<br />
Nombre Escuela:
<asp:TextBox ID="Nombre"  runat="server"></asp:TextBox>
<br />
<br />
Descripcion:
<asp:TextBox ID="descripcion" runat="server"></asp:TextBox>
<br />
<br />
Correo:
<asp:TextBox ID="correo"  runat="server"></asp:TextBox>
<br />
<br />
Telefono:
<asp:TextBox ID="telefono" type="number" runat="server"></asp:TextBox>
<br />
<br />

Codigo Postal:
<asp:TextBox ID="CPostal"  runat="server"></asp:TextBox>
<br />
<br />
Direccion Postal:
<asp:TextBox ID="Dpostal" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click1"  />

<asp:Button ID="Borrar"  runat="server" Text="Borrar" OnClick="Borrar_Click1" />
       
<asp:Button ID="Modificar"  runat="server" Text="Modificar" OnClick="Modificar_Click1"  />

<asp:Button ID="Consultar" runat="server" Text="Consultar" OnClick="Consultar_Click1"  />
        </div>
        
    </form>
</body>
</html>
