<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medico.aspx.cs" Inherits="ClinicaMedica.Medico1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblcrm" runat="server" Text="C.R.M"></asp:Label>
            <asp:TextBox ID="txtcrm" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblnome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
            <asp:TextBox ID="txtcpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblRG" runat="server" Text="RG"></asp:Label>
            <asp:TextBox ID="txtrg" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblendereco" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="txtendereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbltel" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txttel" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btncadastrar" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" />
&nbsp;
            <asp:Button ID="btnalterar" runat="server" Text="Alterar" />
&nbsp;
            <asp:Button ID="btnlimpar" runat="server" Text="Limpar" />
            <br />
            <br />
            <br />
            <asp:GridView ID="gridMedico" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
