<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="validators.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h1><strong>Validators controls:
            </strong></h1>
            
            <asp:Label ID="Label1" runat="server" Text="Enter your Name:"></asp:Label>
            
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;</strong><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter your name.."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <br />
            
            <br />
            
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your password.."></asp:RequiredFieldValidator>
            <br />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Retype your password"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="password doesnt match!!"></asp:CompareValidator>
            <br />
            <br />
            
            <asp:Label ID="Label4" runat="server" Text="Enter Your age:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter your age.."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="only 1-18 age allowed" MaximumValue="18" MinimumValue="1"></asp:RangeValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter Your Email id:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter your email id.."></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid Range!!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox5"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            <br />
            <br />
           
            
            


        </div>
    </form>
</body>
</html>
