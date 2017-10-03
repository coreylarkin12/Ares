<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 165px; width: 826px">
            Nessus Horizon<br />
            <br />
            <br />
            Enter your name:<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="18px" Width="140px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="margin-left: 15px" Text="Display Name" Width="98px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" ForeColor ="Yellow"></asp:Label>
        </div>
    </form>
</body>
</html>
