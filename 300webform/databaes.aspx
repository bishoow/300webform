<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="databaes.aspx.cs" Inherits="_300webform.databaes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Connect Database</title>
</head>
<body>
    <form id="database_form" runat="server">
        <div>
            <asp:Label Text="Roll No" runat="server" />
            <asp:TextBox ID="Name" runat="server" />
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
