<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit_delete.aspx.cs" Inherits="AdoDemo.edit_delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:Button ID="btnGetDataFromDB" runat="server" Text="Get Data From DataBase" OnClick="btnGetDataFromDB_Click" />
            <asp:GridView ID="gvStudent" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId" OnRowCancelingEdit="gvStudent_RowCancelingEdit" OnRowDeleting="gvStudent_RowDeleting" OnRowEditing="gvStudent_RowEditing" OnRowUpdating="gvStudent_RowUpdating" >
                <Columns>
                    <asp:ButtonField Text="Edit" />
                    <asp:ButtonField Text="Delete" />
                    <asp:BoundField DataField="StudentId" HeaderText="StudentId" InsertVisible="False" ReadOnly="True" SortExpression="StudentId" />
                    <asp:BoundField DataField="Full_Name" HeaderText="Full_Name" SortExpression="Full_Name" />
                    <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                    <asp:BoundField DataField="Total_Marks" HeaderText="Total_Marks" SortExpression="Total_Marks" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnUpdateDB" runat="server" Text="Update DataBase" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>

           </div>
    </form>
</body>
</html>
