<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="CIS_3342_TeamProject.MainPage" %>

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
    <style id="55">
        .jumbotron {
            position: relative;
            overflow: hidden;
            height: 500px;
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

            #navigation #signout {
                margin-right: 40px;
            }

        .row {
            text-align: center;
        }

        #gvCars {
            margin-left: 20%;
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
                <br />
            </div>

        </div>

        <br />
        <div class="card-section">
            <div class="container">
                <div class="card-block bg-white mb30">
                    <div class="row">
                        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                            <div class="section-title mb-0">
                                <h1>View our cars</h1>
                                <asp:Button ID="btnAll" class="btn btn-primary btn-lg" runat="server" Text="All Cars" OnClick="btnAll_Click" />
                                <asp:Button ID="btnNew" class="btn btn-primary btn-lg" runat="server" Text="New Cars" OnClick="btnNew_Click" />
                                <asp:Button ID="btnUsed" class="btn btn-primary btn-lg" runat="server" Text="Used Cars" OnClick="btnUsed_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />

      
        <asp:GridView ID="gvCars" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" OnRowCommand="gvCars_RowCommand">
            <Columns>
                <asp:TemplateField>
                     <ItemTemplate>
                        <img id="imgRest" src='<%# Bind("CarPicture") %>' runat="server" style="width: 450px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Label Visible="false" ID="lblID" runat="server" Text='<%# Bind("CarID") %>' Width="0"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Make"  ItemStyle-HorizontalAlign="Center">
                     <ItemTemplate>
                        <asp:Label ID="lblMake" runat="server" Text='<%# Bind("CarMake") %>' Width="150px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Model"  ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Label ID="lblModel" runat="server" Text='<%# Bind("CarModel") %>' Width="150px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Year" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Label ID="lblYear" runat="server" Text='<%# Bind("CarYear") %>' Width="100px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price"  ItemStyle-HorizontalAlign="Center">
                     <ItemTemplate>
                        <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("CarPrice") %>' Width="100px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Color"  ItemStyle-HorizontalAlign="Center">
                     <ItemTemplate>
                        <asp:Label ID="lblColor" runat="server" Text='<%# Bind("CarColor") %>' Width="100px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDetail" runat="server" CommandName="Select" CommandArgument='<%# Container.DataItemIndex %>' Text="More Details" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
                             <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>

    </form>
</body>
</html>
