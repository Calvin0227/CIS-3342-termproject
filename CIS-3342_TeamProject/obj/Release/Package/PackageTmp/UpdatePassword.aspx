<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="CIS_3342_TeamProject.WebForm3" %>

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
        <div>
        </div>
        <p>
            </div>
            </div>
            </div>
            </div>
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        <p>
            &nbsp;<p>
            &nbsp;<div class="row">
                <div class="col">
                    <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </div>
                
            </div>
            
            &nbsp;<asp:Label ID="lblNewPassword" runat="server" Font-Bold="True" Font-Size="X-Large" Text="New Password"></asp:Label>
            <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblNewPassword1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Confirm Password"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtNewPassword1" runat="server"></asp:TextBox>
                </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnChangepassword" runat="server" Text="Change Password" OnClick="btnChangepassword_Click" />
        </p>
        <p>
            <div class="row">
                <div class="col">
                    <asp:Label ID="lblQ1" runat="server" Font-Bold="True" Font-Size="Large" Text="In what city were you born?"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtQ1Answer" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Label ID="lblQ2" runat="server" Font-Bold="True" Font-Size="Large" Text="What high school did you attend?"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtQ2Answer" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Label ID="lblQ3" runat="server" Font-Bold="True" Font-Size="Large" Text="What is the name of your first school?"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtQ3Answer" runat="server"></asp:TextBox>
                </div>
                </div>

            
            

        <p>
            &nbsp;</p>
        <asp:Button ID="btnCheckAccont" runat="server" OnClick="Button1_Click" Text="Check Account" />

            
            

    </form>

</body>
</html>
