<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsPizza.Default" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <!-- Header Section -->
            <div class="containter my-3">
                <h1 class="font-weight-bold">Papa Bob's Pizza</h1>
                <p class="lead">Pizza to Code By</p>
            </div>
            <!-- End Header Section -->

            <br />

            <!-- Order Section -->
            <div class="containter my-3">

                <!-- Pizza Size -->
                <label class="font-weight-bold">Size</label>
                <asp:DropDownList ID="sizeDropDown" runat="server" CssClass="form-control">
                    <asp:ListItem Value="0">Small (12 inch - $12)</asp:ListItem>
                    <asp:ListItem Value="1">Medium (14 inch - $14)</asp:ListItem>
                    <asp:ListItem Value="2">Large (16 inch - $16)</asp:ListItem>
                </asp:DropDownList>

                <!-- Crust Type -->
                <label class="font-weight-bold">Crust</label>
                <asp:DropDownList ID="crustDropDown" runat="server" CssClass="form-control">
                    <asp:ListItem Value="0">Regular</asp:ListItem>
                    <asp:ListItem Value="1">Thin</asp:ListItem>
                    <asp:ListItem Value="2">Thick (+ $2)</asp:ListItem>
                </asp:DropDownList>

                <!-- Toppings -->
                <div class="my-3">
                    <div class="input-group py-1"><asp:CheckBox ID="sausageCheckBtn" runat="server" CssClass="mx-2"/>Sausage</div>
                    <div class="input-group py-1"><asp:CheckBox ID="peperoniCheckBtn" runat="server" CssClass="mx-2"/>Pepperoni</div>
                    <div class="input-group py-1"><asp:CheckBox ID="onionsCheckBtn" runat="server" CssClass="mx-2"/>Onions</div>
                    <div class="input-group py-1"><asp:CheckBox ID="greenPeppersCheckBtn" runat="server" CssClass="mx-2"/>Green Peppers</div>
                </div>
            </div>
            <!-- End Order Section -->

            <br />

            <!-- Delivery Section -->
            <div class="containter my-3">
                <h2 class="font-weight-bold">Deliver To:</h2>

                 <div><label class="font-weight-bold">Name:</label><asp:TextBox ID="nameBox" runat="server" CssClass="form-control"></asp:TextBox></div>
                 <div><label class="font-weight-bold">Address:</label><asp:TextBox ID="addressBox" runat="server" CssClass="form-control"></asp:TextBox></div>
                 <div><label class="font-weight-bold">Zipcode:</label><asp:TextBox ID="zipBox" runat="server" CssClass="form-control"></asp:TextBox></div>
                 <div><label class="font-weight-bold">Phone:</label><asp:TextBox ID="phoneBox" runat="server" CssClass="form-control"></asp:TextBox></div>
            </div>
            <!-- End Delivery Section -->

            <br />

            <!-- Payment Section -->
            <div class="containter my-3">
                <h2 class="font-weight-bold">Payment:</h2>
                <div class="input-group py-1"><asp:RadioButton ID="cashRadioBtn" runat="server" GroupName="Payment" CssClass="mx-2" Checked="true" />Cash</div>
                <div class="input-group py-1"><asp:RadioButton ID="creditRadioBtn" runat="server" GroupName="Payment" CssClass="mx-2" />Credit</div>
                
                <!-- Place Order Button -->
                <div class="mt-2"><asp:Button ID="orderButton" runat="server" Text="Place Order" CssClass="btn btn-primary" OnClick="orderButton_Click" /></div>
                <div><asp:Label ID="errorLabel" runat="server" CssClass="text-danger font-weight-bold"></asp:Label></div>
            </div>
            <!-- End Payment Section -->

            <br />

            <!-- Cost Section -->
            <div class="containter my-3">
                <h2>Total Cost:
                <asp:Label ID="costLabel" runat="server" CssClass="font-weight-bold"></asp:Label></h2>
            </div>
            <!-- End Cost Section -->

        </div>
    </form>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
