<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default2.aspx.cs" Inherits="linq.default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 229px;
        }
        .auto-style3 {
            width: 118px;
        }
        .auto-style4 {
            width: 420px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <br />
            <br />
            <table>
                <tr>
                    <td class="auto-style2">Enter Product_Name</td>
                    <td class="auto-style3">:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Product_Price</td>
                    <td class="auto-style3">:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Add" />
                    </th>
                    <th class="auto-style3">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                    </th>
                    <th class="auto-style4">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                    </th>
                </tr>
                <tr>
                    <th class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </th>
                    <th class="auto-style3">&nbsp;</th>
                    <th class="auto-style4">&nbsp;</th>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="PName" HeaderText="PName" SortExpression="PName" />
                    <asp:BoundField DataField="PPrice" HeaderText="PPrice" SortExpression="PPrice" />
                </Columns>
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
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CollegeConnectionString %>" SelectCommand="SELECT * FROM [Product1]"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
   
</body>
</html>
