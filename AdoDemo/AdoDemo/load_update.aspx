<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="load_update.aspx.cs" Inherits="AdoDemo.load_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 138px;
        }
        .auto-style3 {
            width: 138px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">StudentID</td>
                    <td>
                        <asp:TextBox ID="stuID" runat="server" Width="193px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="loadInfo" runat="server" OnClick="Button1_Click" Text="Load" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="stuName" runat="server" Width="193px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td>
                        <asp:DropDownList ID="stuGender" runat="server">
                            <asp:ListItem Value="-1">Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Total Marks</td>
                    <td>
                        <asp:TextBox ID="stuMarks" runat="server" Width="193px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="status" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
            </table>

            <br />
            <br />
            <asp:Label ID="lblupdate" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblDelete" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblInsert" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
