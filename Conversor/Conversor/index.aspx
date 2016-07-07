<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Conversor.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload_Ejercicio" runat="server" />

        <br />
        <br />
        <asp:Button ID="BtnConversor" runat="server" Text="Convertir" OnClick="BtnConversor_Click" Width="601px" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ===========&gt; crear una carpeta en c:/corregido/ &lt;============</div>
    </form>
</body>
</html>
