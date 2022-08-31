<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormTable.aspx.cs" Inherits="AdoDemo.FormTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="App_Themes/Theme1/StyleSheet1.css" rel="stylesheet" />

    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
        }
        .auto-style3 {
            width: 199px;
        }
        .auto-style4 {
            width: 199px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">First Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Last Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Gender</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Salary</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>

            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="Employee Data" />
            <br />
            <br />
            <asp:GridView ID="employeetbl" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>

        </div>
    </form>
</body>
</html>
