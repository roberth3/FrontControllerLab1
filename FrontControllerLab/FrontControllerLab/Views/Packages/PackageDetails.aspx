﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PackageDetails.aspx.cs" Inherits="FrontControllerLab.Views.Packages.PackageDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelPackageName" runat="server" Text="PackageName"></asp:Label>
        </br>

        <asp:Label ID="LabelDiscription" runat="server" Text="Discription"></asp:Label>
        </br>
        <asp:Label ID="LabelAdultPrice" runat="server" Text="AdultPrice"></asp:Label>
    </div>
    </form>
</body>
</html>
