<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="ClinicaMedica.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbldata" runat="server" Text="Data"></asp:Label>
            <asp:TextBox ID="txtdata" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblpaciente" runat="server" Text="Paciente"></asp:Label>
            <asp:DropDownList ID="ddlpaciente" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblmedico" runat="server" Text="Medico"></asp:Label>
            <asp:DropDownList ID="ddlmedico" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblexame" runat="server" Text="Exame"></asp:Label>
            <asp:DropDownList ID="ddlexame" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btncadastrar" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" style="height: 26px" />
            <br />
            <br />
            <asp:GridView ID="gridconsulta" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
