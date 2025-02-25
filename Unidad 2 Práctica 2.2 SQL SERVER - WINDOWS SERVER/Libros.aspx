<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="BibliotecaWeb.Libros" %>

<!DOCTYPE html>

<html lang="es">
<head>
<meta charset="utf-8"/>
    <title>Biblioteca Digital</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            ISBN:<asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>
        </p>
        Título:<asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
        <p>
            Número de Edición:<asp:TextBox ID="txtNoEdicion" runat="server"></asp:TextBox>
        </p>
        Año de Publicación:<asp:TextBox ID="txtPublicacion" runat="server"></asp:TextBox>
        <p>
            Nombre de los Autores:<asp:TextBox ID="txtAutores" runat="server"></asp:TextBox>
        </p>
        País de Publicación:<asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
        <p>
            Sinopsis:<textarea id="txtaSinopsis" cols="20" name="S1" rows="2" runat="server"></textarea>
        </p>
        Carrera:<asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox>
        <p>
            Materia:<asp:TextBox ID="txtMateria" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        <br />
        <br />
        Lista de Libros<br />
        <asp:GridView ID="gvLibros" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
