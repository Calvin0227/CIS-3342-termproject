<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="CIS_3342_TeamProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
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
            height: 450px;
            background-repeat: no-repeat;
            background-size: cover;
            background-image: linear-gradient(to bottom, rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.6) 100%), url(images/rs5avant.png);
            margin-bottom: 0;
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
        <nav class="navbar navbar-default" runat="server" id="navigation">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand active" href="MainPage.aspx">Home Page</a>
                </div>
                <ul class="nav navbar-nav">

                    <li runat="server" visible="true"><a href="Service.aspx">Services</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li id="signout"><a href="LoginPage.aspx">Sign Out</a></li>
                </ul>
            </div>
        </nav>
        <div class="jumbotron">
            <div class="container">
                <h1 class="display-4">term project dealership!</h1>
                <p class="lead">Check out here! Make sure your information is correct.</p>
                <hr class="my-4" />
                <br />
            </div>

        </div>
        <div>
            <br />
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" Text="Display All Service" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblTime" runat="server" Text="Time Format is yyyy-mm-dd hh:mm"></asp:Label>
            <br />
            <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="gvService" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="245px" Width="837px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ServiceTypeID" HeaderText="Service ID" />
                    <asp:BoundField DataField="ServiceName" HeaderText="Service Name" />
                    <asp:BoundField DataField="HourlyRate" HeaderText="Hourly Rate (/h)" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
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
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="175px" />
            <br />
            <br />
            <asp:GridView ID="gvReport" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="315px" Width="883px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                <asp:BoundField DataField="User" HeaderText="User ID" />
                <asp:BoundField DataField="Serviceid" HeaderText="Service ID" />
                <asp:BoundField DataField="Servicename" HeaderText="Service Name" />
                <asp:BoundField DataField="Servicerate" DataFormatString="{0:c}" HeaderText="Price" />
                <asp:BoundField DataField="Servicetime" HeaderText="Time" />
                </Columns>
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
        </div>
    </form>
</body>
</html>
