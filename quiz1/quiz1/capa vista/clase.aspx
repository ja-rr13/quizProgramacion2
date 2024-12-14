<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clase.aspx.cs" Inherits="quiz1.capa_vista.clase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>TABLA CLASE</h2>
                        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            <br />
            <br />
ClaseID:
<asp:TextBox ID="CID" type="number" runat="server"></asp:TextBox>
<br />
<br />
Nombre Clase:
<asp:TextBox ID="NombreC"  runat="server"></asp:TextBox>
<br />
<br />
Descripcion:
<asp:TextBox ID="descripcion" runat="server"></asp:TextBox>
<br />
<br />
EscuelaID:
<asp:TextBox ID="EscuelaID" type="number" runat="server"></asp:TextBox>
<br />
<br />

<asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click"   />

<asp:Button ID="Borrar"  runat="server" Text="Borrar" OnClick="Borrar_Click"  />
       
<asp:Button ID="Modificar"  runat="server" Text="Modificar" OnClick="Modificar_Click"   />

<asp:Button ID="Consultar" runat="server" Text="Consultar" OnClick="Consultar_Click"   />
        </div>
    </form>
</body>
</html>
