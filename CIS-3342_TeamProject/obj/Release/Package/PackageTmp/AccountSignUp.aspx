<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountSignUp.aspx.cs" Inherits="CIS_3342_TeamProject.WebForm1" %>

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
    </style>
    <script type="text/javascript">
        var timer;
        function init()
        {
            timer = setInterval("retrieveName()", 3000);
        }
        function uninit()
        {
            clearInterval(timer);
        }
        function retrieveName()
        {
            CIS_3342_TeamProject.WebService2.convertName(document.getElementById("txtFirstName1").value, onComplete);
        }
        function onComplete(data)
        {
            document.getElementById("display_area").innerHTML = "Hi," + data + "Welcome to the family";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID ="ScriptManager1" runat="server" EnablePageMethods="true">
                <Services>
                <asp:ServiceReference Path="~/ShowService.asmx" />

            </Services>
            </asp:ScriptManager>
            <nav class="navbar navbar-default" runat="server" id="navigation">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand active" href="MainPage.aspx">Home Page</a>
                </div>

            </div>
                 <div id="display_area"></div>
        </nav>
            </div>
            <br />
            <asp:Label ID="lblNotification" runat="server"></asp:Label>
       
            <br />
            <asp:Button ID="btnResetPassword" runat="server" Height="36px" OnClick="btnResetPassword_Click" Text="Click Here If You Forgot your password" Width="383px" />
            <br />
            
            <br />

            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" Width="250px" TabIndex="1"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"  CssClass="form-control input-lg" Width="250px" TabIndex="1"></asp:TextBox>
            
            <br />
            <br />


            <div class="col-md-4 mb-3">
                <asp:TextBox ID="txtEmailAddress" class="form-control" runat="server" placeholder ="Email" CssClass="form-control" ></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <asp:TextBox ID="txtPassword" class="form-control" runat="server" placeholder="password"></asp:TextBox>
                <small id="passwordHelpInline" class="text-muted">Must be 8-20 characters long.</small>
            </div>

            



        &nbsp;
        <br />
        <br />



         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        <br />
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name" onfocus="init()" ></asp:TextBox>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingFirstName" runat="server" placeholder="Billing First Name"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblQ1" runat="server" Text="In what city were you born?"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQ1Answer" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtLastName" runat="server" placeholder ="Last Name"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingLastName" runat="server" placeholder="Billing Last Name"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblQ2" runat="server" Text="What high school did you attend?"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQ2Answer" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtHomeAddress1" runat="server" placeholder="Home Address 1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingAddress1" runat="server" placeholder="Billing Address 1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblQ3" runat="server" Text="What is the name of your first school?"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtQ3Answer" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtHomeAddress2" runat="server" placeholder="Home Address 2"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingAddress2" runat="server" placeholder="Billing Address 2" ></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtHomeAddressCity" runat="server" placeholder ="Home City"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingCity" runat="server" placeholder ="Billing City"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtHomeAddressState" runat="server" placeholder="Home State"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingState" runat="server" placeholder="Billing State"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="txtHomeAddressZip" runat="server" placeholder="Home Zip"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBillingZip" runat="server" placeholder ="Billing Zip"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="cboxEmail" runat="server" Text="Send Confirmation Email" />
        <br />

        <asp:CheckBox ID="cboxSaveCookie" runat="server" Text="Save Cookie for faste Login" />
        <br />
        <asp:CheckBox ID="CboxSameBilling" runat="server" Text="Same As Billing"  />
        <br />
        
        <br />
        <br />
        <asp:Button ID="btnNextStep" runat="server" OnClick="btnNextStep_Click" Text="Next Step" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
