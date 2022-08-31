<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trial.aspx.cs" Inherits="AdoDemo.trial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:Button ID="Get_Data" runat="server" Text="Get Data" OnClick="Get_Data_Click" />
        &nbsp;<br />
            <br />
            <asp:GridView ID="gvStudent" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataKeyNames="act_id" OnRowCancelingEdit="gvStudent_RowCancelingEdit" OnRowDeleting="gvStudent_RowDeleting" OnRowEditing="gvStudent_RowEditing" OnRowUpdating="gvStudent_RowUpdating">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="act_id" HeaderText="act_id" ReadOnly="True" SortExpression="act_id" />
                    <asp:BoundField DataField="act_fname" HeaderText="act_fname" SortExpression="act_fname" />
                    <asp:BoundField DataField="act_lname" HeaderText="act_lname" SortExpression="act_lname" />
                    <asp:BoundField DataField="act_gender" HeaderText="act_gender" SortExpression="act_gender" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
