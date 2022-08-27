<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdoDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            SqlConnection con2 = new SqlConnection(&quot;data source=JANVI-DESAI<a href="file://SQLEXPRESS">\\SQLEXPRESS</a>; database=Sample; Integrated Security=SSPI;&quot;);
            <br />
            SqlCommand cmd2 = new SqlCommand(&quot;Select * from student&quot;, con2);
            <br />
            con2.Open();
            <br />
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            <br />
            GridView2.DataSource = rdr2;
            <br />
            GridView2.DataBind();
            <br />
            con2.Close();<br />
            <br />
            <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
<%--            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
&nbsp;<br />
            SqlConnection con1 = new SqlConnection(&quot;data source=JANVI-DESAI<a href="file://SQLEXPRESS;%20database=w3schools;%20Integrated%20Security=SSPI;">\\SQLEXPRESS; database=w3schools; Integrated Security=SSPI;</a>&quot;);
            <br />
            SqlCommand cmd1 = new SqlCommand(&quot;Select * from orders&quot;, con1);
            <br />
            con1.Open();
            <br />
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            <br />
            GridView1.DataSource = rdr1;<br />
            GridView1.DataBind();
            <br />
            con1.Close();<br />
            <br />
            <br />--%>
            Best of Luck.. ;)<br />
        </div>
    </form>
</body>
</html>
