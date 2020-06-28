<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exame.aspx.cs" Inherits="ClinicaMedica.Exame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbltipo" runat="server" Text="Tipo"></asp:Label>
            <asp:TextBox ID="txttipo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblvalor" runat="server" Text="Valor"></asp:Label>
            <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btncadastrar" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" />
&nbsp;
            <asp:Button ID="btnalterar" runat="server" Text="Alterar" />
&nbsp;
            <asp:Button ID="btnlimpar" runat="server" Text="Limpar" />
            <br />
            <br />
            <asp:GridView ID="gridexame" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
