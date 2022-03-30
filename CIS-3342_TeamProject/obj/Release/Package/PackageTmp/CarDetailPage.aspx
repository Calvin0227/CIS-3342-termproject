<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarDetailPage.aspx.cs" Inherits="CIS_3342_TeamProject.CarDetailPage" %>

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
            font-size : 20px;
        }

        #specs {
            text-align: center;
            margin-top: 5%;
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
                <hr class="my-4" />
                <br />
            </div>

        </div>
        <br />
        <br />

        <div class="container-fluid">
            <div class="row">
                <div class="col-4">
                    <asp:Label ID="lblPrice" runat="server" Text="MSRP: "></asp:Label>
                    <asp:Label ID="lblCarPrice" runat="server" Text="$250,000"></asp:Label>
                    <br />
                    <asp:Label ID="lblVin" runat="server" Text="Vin Number: "></asp:Label>
                    <asp:Label ID="lblCarVin" runat="server" Text="testing12345623d"></asp:Label>

                </div>

                <div class="col-6">
                    <asp:Label ID="lblMake" runat="server" Text="Make: "></asp:Label>
                    <asp:Label ID="lblCarMake" runat="server" Text="Tesla"></asp:Label>
                    <asp:Label ID="lblModel" runat="server" Text="Mode: "></asp:Label>
                    <asp:Label ID="lblCarModel" runat="server" Text="Plaid S"></asp:Label>
                    <br />
                    <asp:Label ID="lblYear" runat="server" Text="Year: "></asp:Label>
                    <asp:Label ID="lblCarYear" runat="server" Text="2022"></asp:Label>
                    <br />
                    <asp:Label ID="lblColor" runat="server" Text="Color: "></asp:Label>
                    <asp:Label ID="lblCarColor" runat="server" Text="Red"></asp:Label>

                </div>
            </div>
            <div class="row">
                <div class="col">
                    <img id="imgRest" src="https://media.ed.edmunds-media.com/tesla/model-s/2021/oem/2021_tesla_model-s_sedan_plaid_fq_oem_1_1600.jpg" runat="server" style="width: 800px" />
                </div>
                <div class="col" id="specs">
                    <asp:Label ID="lblSpecs" runat="server" Text="The BRZ is a high-performance sports car for demanding drivers. With a 2.4-liter, 228 hp engine and track-tuned suspension"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnOrder" runat="server" class="btn btn-info" Text="Order" OnClick="btnOrder_Click" />
                </div>
            </div>

            <br />

        </div>



    </form>
</body>
</html>
