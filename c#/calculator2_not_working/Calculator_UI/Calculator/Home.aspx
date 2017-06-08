<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Calculator.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 503px">
    
        <asp:TextBox ID="TextBox3" runat="server" Width="152px" BorderColor="Black" BorderStyle="Solid" Height="42px"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Height="40px" Text="Clear" Width="160px" />
        <br />
        <asp:Button ID="Button6" runat="server" Height="40px" Text="7" Width="40px" Font-Bold="True" OnClick="Button6_Click" />
        <asp:Button ID="Button7" runat="server" Height="40px" Text="8" Width="40px" Font-Bold="True" OnClick="Button7_Click" />
        <asp:Button ID="Button8" runat="server" Height="40px" Text="9" Width="40px" Font-Bold="True" OnClick="Button8_Click" />
        <asp:Button ID="Button9" runat="server" Height="40px" Text="/" Width="40px" Font-Bold="True" OnClick="Button9_Click" />
        <br />
        <asp:Button ID="Button10" runat="server" Height="40px" Text="4" Width="40px" Font-Bold="True" OnClick="Button10_Click" />
        <asp:Button ID="Button11" runat="server" Height="40px" Text="5" Width="40px" Font-Bold="True" OnClick="Button11_Click" />
        <asp:Button ID="Button12" runat="server" Height="40px" Text="6" Width="40px" Font-Bold="True" OnClick="Button12_Click" />
        <asp:Button ID="Button13" runat="server" Height="40px" Text="*" Width="40px" Font-Bold="True" OnClick="Button13_Click" />
        <br />
        <asp:Button ID="Button14" runat="server" Height="40px" Text="1" Width="40px" Font-Bold="True" OnClick="Button14_Click" />
        <asp:Button ID="Button15" runat="server" Height="40px" Text="2" Width="40px" Font-Bold="True" OnClick="Button15_Click" />
        <asp:Button ID="Button16" runat="server" Height="40px" Text="3" Width="40px" Font-Bold="True" OnClick="Button16_Click" />
        <asp:Button ID="Button17" runat="server" Height="40px" Text="-" Width="40px" Font-Bold="True" OnClick="Button17_Click" />
        <br />
        <asp:Button ID="Button18" runat="server" Height="40px" Text="0" Width="40px" Font-Bold="True" OnClick="Button18_Click" />
        <asp:Button ID="Button19" runat="server" Height="40px" Text="." Width="40px" Font-Bold="True" OnClick="Button19_Click" />
        <asp:Button ID="Button20" runat="server" Height="40px" Text="=" Width="40px" Font-Bold="True" OnClick="Button20_Click" />
        <asp:Button ID="Button21" runat="server" Height="40px" Text="+" Width="40px" Font-Bold="True" OnClick="Button21_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
       
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
