<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ajax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/download1.jpg" />
            <h1> This is a Dynamic webpage!!</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval ="1000" OnTick="Timer1_Tick"></asp:Timer>
                <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true" Font-Size="X-Large" ></asp:Label>
            </ContentTemplate>
        </div>
    </form>
</body>
</html>
