<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ClinicaMedica.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Cadastro" Value="Cadastro">
                        <asp:MenuItem Text="Paciente" Value="Paciente"></asp:MenuItem>
                        <asp:MenuItem Text="Medico" Value="Medico"></asp:MenuItem>
                        <asp:MenuItem Text="Exame" Value="Exame"></asp:MenuItem>
                        <asp:MenuItem Text="Consulta" Value="Consulta"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
