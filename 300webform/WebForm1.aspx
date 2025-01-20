<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webform.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Web Form</title>
</head>
<body>
    <div>
        <form id="RegistrationForm" runat="server">
            <div>
                <h1>STUDENT Registration Form</h1>
                <div>
                    <asp:Label Text="FullName" runat="server" />
                    <asp:TextBox ID="input_fullname" runat="server" />
                </div>
                <div>
                    <asp:Label Text="DoB" runat="server" />
                    <asp:TextBox ID="input_dob" runat="server" />
                </div>
                <div>
                    <asp:Label Text="Father Name" runat="server" />
                    <asp:TextBox ID="input_father" runat="server" />
                </div>
                <div>
                    <asp:Label Text="Mother Name" runat="server" />
                    <asp:TextBox ID="input_mother" runat="server" />
                </div>
                <div>
                    <asp:Label Text="Gender" runat="server" />
                    <span>
                        <asp:RadioButton ID="male" Text="Male" runat="server" GroupName="gender" />
                        <asp:RadioButton ID="female" Text="Female" runat="server" GroupName="gender" />
                        <asp:RadioButton ID="other" Text="Other" runat="server" GroupName="gender" />
                    </span>
                </div>
                <div>
                    <asp:Label Text="Address" runat="server" />
                    <div style="display:flex; flex-direction:row;">
                        <div>
                            <asp:Label Text="State" runat="server" />
                            <asp:DropDownList ID="state" runat="server" OnSelectedIndexChanged="LoadDistrictOnStateSelect" AutoPostBack="True"/>
                        </div>
                        <div>
                            <asp:Label Text="District" runat="server" />
                            <asp:DropDownList ID="district" runat="server" OnSelectedIndexChanged="LoadMunicipalityOnDistrictSelect" AutoPostBack="True"/>
                        </div>
                        <div>
                            <asp:Label Text="Municipality" runat="server" />
                            <asp:DropDownList ID="municipality" runat="server" OnSelectedIndexChanged="LoadWardNoOnMunicipalitySelect" AutoPostBack="True"/>
                        </div>
                        <div>
                            <asp:Label Text="Ward No." runat="server" />
                            <asp:DropDownList ID="wardno" runat="server" />
                        </div>
                    </div>
                </div>
                <div>
                    <asp:CheckBox ID="tos" Text="Terms and Condition" runat="server" />
                </div>
                <div style="margin:auto auto;">
                    <button type="submit" > Submit </button>
                </div>
            </div>
        </form>
    </div>
</body>
</html>