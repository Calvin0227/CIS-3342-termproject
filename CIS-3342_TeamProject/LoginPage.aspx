<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CIS_3342_TeamProject.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <style>
        .container {
            margin-top: 10%;
            width:60%;
        }

        #pic {
            width: 100%;
        }

        .alerts{
            width:20%;
            margin-left:40%;
        }
        #btnLogin{
            width:150px;
        }
        #btnAdd{
            width: 140px;
            float:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div id="loginbox" class="mainbox col-md-6 col-md-offset-3 col-sm-6 col-sm-offset-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title text-center">Car buying thing</div>
                    </div>

                    <div class="panel-body">
                        <img id="pic" src="https://blog.leadsplease.com/wp-content/uploads/2019/06/Car-dealership.jpg" class="brand_logo" />
                    </div>

                    <div class="panel-body" runat="server" id="login">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox class="form-control" ID="txtlog" runat="server"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">

                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox type="password" class="form-control" ID="txtPassword" runat="server"></asp:TextBox>
                        </div>
                        <br />
                        <div class="col-sm-12 controls">
                            <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Visible="true" Text="Login" OnClick="btnLogin_Click" />
                            <asp:Button ID="btnAdd" class="btn btn-info" runat="server" Visible="true" Text="Register" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="alerts">
            <div class="alert alert-warning" role="alert" runat="server" id="warning" visible="false">
                <strong>Warning!</strong> Enter Username and Password
            </div>

            <div class="alert alert-danger" role="alert" runat="server" id="error" visible="false">
                <strong>Error!</strong> Account not found
            </div>
            <div class="alert alert-success" role="alert" runat="server" id="message" visible="false"></div>
            <div class="alert alert-success" role="alert" runat="server" id="message2" visible="false"></div>
        </div>
    </form>
</body>
</html>
