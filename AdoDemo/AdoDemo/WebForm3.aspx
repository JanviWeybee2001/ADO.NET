<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="AdoDemo.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadData" runat="server" Text="Load Data" OnClick="btnLoadData_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnClearCache" runat="server" Text="Clear Cache" OnClick="btnClearCache_Click" />
&nbsp;
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GvEmployee" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
