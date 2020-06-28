<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="ClinicaMedica.Paciente1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblnome" runat="server" Text="Nome"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblRG" runat="server" Text="RG"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtrg" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblendereco" runat="server" Text="Endereço"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtendereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbltel" runat="server" Text="Telefone"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txttel" runat="server" TextMode="Phone"></asp:TextBox>
            <br />
            <asp:Label ID="lblemail" runat="server" Text="E-mail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btncadastrar" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" />
&nbsp;
            <asp:Button ID="btnalterar" runat="server" Text="Alterar" OnClick="btnalterar_Click1" />
&nbsp;
            <asp:Button ID="btnlimpar" runat="server" OnClick="btnlimpar_Click" Text="Limpar" />
            <br />
            <br />
            <asp:GridView ID="GridPaciente" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
