<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutPage.aspx.cs" Inherits="CIS_3342_TeamProject.CheckoutPage" %>

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

            #navigation #signout {
                margin-right: 40px;
            }

        .row {
            font-size: 22px;
            text-align: center;
            margin-left: 25px;
        }

        #car {
            width: 100%;
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

        <br />

        <!--For Page-->
        <div id="car">
            <!--Card 1-->
            <div class="col-sm-8">
                <div class="desc">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblMake" runat="server" Text="Make: "></asp:Label>
                            <asp:Label ID="lblCarMake" runat="server" Text="Tesla"></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblModel" runat="server" Text="Mode: "></asp:Label>
                            <asp:Label ID="lblCarModel" runat="server" Text="Plaid S"></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblYear" runat="server" Text="Year: "></asp:Label>
                            <asp:Label ID="lblCarYear" runat="server" Text="2022"></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblColor" runat="server" Text="Color: "></asp:Label>
                            <asp:Label ID="lblCarColor" runat="server" Text="Red"></asp:Label>
                        </div>
                    </div>

                </div>

                <br />
                <div class="view view-cascade overlay text-center">
                    <img id="imgRest" runat="server" class="card-img-top" src="https://media.ed.edmunds-media.com/tesla/model-s/2021/oem/2021_tesla_model-s_sedan_plaid_fq_oem_1_1600.jpg" alt="" style="width: 60%" />
                    <a>
                        <div class="mask rgba-white-slight"></div>
                    </a>
                </div>

            </div>
            <br />

            <div class="col">
                <div class="card card-cascade">
                    <div class="card-body card-body-cascade">
                        <div class="CustInfo">
                            <h2>Check Out</h2>
                            <p>
                                First Name <span class="float-right text1">
                                    <asp:Label ID="lblFirstName" runat="server" Text="first Name"></asp:Label></span>
                            </p>

                            <p>Last Name<span class="float-right text1"><asp:Label ID="lblLastName" runat="server" Text="first Name"></asp:Label></span> </p>

                            <p>Shipping Address<span class="float-right text1"><asp:Label ID="lblShipping" runat="server" Text="123 Sesame Street Phila Pa 19876"></asp:Label></span></p>

                            <p>Billing Addredss<span class="float-right text1"><asp:Label ID="lblBilling" runat="server" Text="123 Sesame Street Phila Pa 19876"></asp:Label></span></p>

                            <p>Phone Number<span class="float-right totalText1"><asp:Label ID="lblNumber" runat="server" Text="1236547890"></asp:Label></></span></p>

                            <p>Email Address<span class="float-right totalText1"><asp:Label ID="lblEmail" runat="server" Text="test@gmail.com"></asp:Label></></span></p>
                        </div>
                        <div class="payment">
                            <p><strong>Price</strong></p>
                            <p>MSRP<span class="float-right">
                                <asp:Label ID="lblPrice" runat="server" Text="12345"></asp:Label></span></p>

                            <p>Vin Number<span class="float-right"><asp:Label ID="lblVin" runat="server" Text="12345"></asp:Label></span></p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:Button ID="btnOrder" runat="server" class="btn btn-success" Text="Order" OnClick="btnOrder_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="popup" tabindex="-1" aria-hidden="true" runat="server" visible="false">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Thank you for ordering your Car!</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        Your Car has been successfully ordered
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnClose" class="btn btn-secondary" runat="server" Text="Close"  OnClick="btnClose_Click" />
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
