<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="registration.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow ID ="TableRow" runat ="server">
                    <asp:TableCell ID ="TableCell" runat="server">
                        <asp:Label ID ="Label1" runat="server" Text="Name:"></asp:Label>
                </asp:TableCell>

                    <asp:TableCell ID ="TableCell2" runat="server">
                        <asp:TextBox ID ="TextBox1" runat="server"></asp:TextBox>
                </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow ID ="TableRow2" runat ="server">
                    <asp:TableCell ID ="TableCell3" runat="server">
                        <asp:Label ID ="Label2" runat="server" Text="Password:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell ID ="TableCell4" runat="server">
                        <asp:TextBox ID ="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </asp:TableCell>
                </asp:TableRow>

                
                 <asp:TableRow ID ="TableRow3" runat ="server">
                    <asp:TableCell ID ="TableCell5" runat="server">
                        <asp:Label ID ="Label3" runat="server" Text="Confirm Password:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell ID ="TableCell6" runat="server">
                        <asp:TextBox ID ="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow ID ="TableRow4" runat ="server">
                    <asp:TableCell ID ="TableCell7" runat="server">
                        <asp:Label ID ="Label4" runat="server" Text="City:"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell ID ="TableCell8" runat="server">
                         <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Mumbai</asp:ListItem>
                             <asp:ListItem>Pune</asp:ListItem>
                             <asp:ListItem>Raigad</asp:ListItem>
                             <asp:ListItem>Ratnagiri</asp:ListItem>
                         </asp:DropDownList>
                    </asp:TableCell>
                    </asp:TableRow>

                <asp:TableRow ID ="TableRow5" runat ="server">
                    <asp:TableCell ID ="TableCell9" runat="server">
                        <asp:Label ID ="Label5" runat="server" Text="Gender:"></asp:Label>
                    </asp:TableCell>

                    <asp:TableCell ID ="TableCell10" runat="server">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gen" Text="Male" />  
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gen" Text="Female"/>
                </asp:TableCell>
                </asp:TableRow>

                
                <asp:TableRow ID ="TableRow6" runat ="server">
                    <asp:TableCell ID ="TableCell11" runat="server">
                        <asp:Label ID ="Label6" runat="server" Text="Gmail:"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell ID ="TableCell12" runat="server">
                       <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
                    </asp:TableCell>
                 </asp:TableRow>  

                <asp:TableRow ID="TableRow7" runat ="server">
                    <asp:TableCell ID ="TableCell13" runat="server">
                        <asp:Button ID ="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </asp:TableCell>
                    <asp:TableCell ID ="TableRow8" runat="server">
                        <asp:Label ID="Label8" runat="server" Text="" />
                    </asp:TableCell>
                </asp:TableRow>
          </asp:Table>
            
        </div>
    </form>
</body>
</html>
