<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingServicePageForAdmin.aspx.cs" Inherits="CIS_3342_TeamProject.ServiceForUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <title></title>
    <style>
        .jumbotron {
            position: relative;
            overflow: hidden;
            height: 500px;
            background-repeat: no-repeat;
            background-size: cover;
            background-image: linear-gradient(to bottom, rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.6) 100%), url(images/rs5avant.png);
            margin-bottom: 0;
            top: 1px;
            left: 4px;
        }

            .jumbotron .container {
                position: relative;
                z-index: 2;
                background: rgba(0,0,0,0.3);
                padding: 2rem;
                border: 1px solid rgba(0,0,0,0.1);
                border-radius: 3px;
                color: white;
                font-size: 20px;
            }

        #navigation {
            margin: 0;
            font-size: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <nav class="navbar navbar-default" runat="server" id="navigation">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand active" href="MainPage.aspx">Home Page</a>
                </div>
                <ul class="nav navbar-nav navbar-right">
                    <li id="signout"><a href="LoginPage.aspx">Sign In</a></li>
                </ul>
            </div>
        </nav>

        <div class="jumbotron">
            <div class="container">
                <h1 class="display-4">term project dealership!</h1>
                <br />
            </div>

        </div>
        <br />
        <div class="row">
            <div class ="row-3 ">
            <div class=" col">
                        <asp:Label ID="lblServiceName" runat="server" Text="Service Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                        <asp:TextBox ID="txtServiceName" runat="server"></asp:TextBox>

            </div>
                </div>
            <div class ="row-3 ">
                        <asp:Label ID="lblHourRate" runat="server" Text="Hourly Rate" Font-Bold="True" Font-Size="Large"></asp:Label>
                        <asp:TextBox ID="txtHourlyRate" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSubmit" runat="server" Height="36px" OnClick="btnSubmit_Click" Text="Adding New Service" Width="155px" Font-Bold="True" />

            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        What Status You Want Change:
        <asp:TextBox ID="txtCustomerstatus" runat="server">Status</asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server">Customer ID</asp:TextBox>
        <br />
&nbsp;<br />
        <div class="row -3">
            <div class=" row">
                <asp:Button ID="btnDisplayAllCustomer" runat="server" Text="Display All Customer" Height="37px" OnClick="btnDisplayAllCustomer_Click" Width="252px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnChangeStatus" runat="server" Text="Change Customer Status" Height="37px" OnClick="btnChangeStatus_Click" Width="278px" />

            </div>
            <div class="row-3">

            </div>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        Service ID:
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnFIndServiceByID" runat="server" Height="19px" Text="Find Service By ID" Width="144px" OnClick="btnFIndServiceByID_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAllServices" runat="server" Height="20px" Text="Display All Services" Width="140px" OnClick="btnDisplayAllServices_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDeleteService" runat="server" Height="20px" Text="Delete Service By ID" Width="140px" OnClick="btnDeleteService_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAllOrder" runat="server" Height="20px" Text="Display All Oder" Width="140px" OnClick="btnDisplayAllOrder_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gvServices" runat="server" Height="141px" Width="667px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
    </form>
</body>
</html>
