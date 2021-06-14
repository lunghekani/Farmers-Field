<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Farmers_Field_UI.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="hero-wrap hero-bread" style="background-image: url('images/jake-gard-CetB-bTDBtY-unsplash (4).jpg');">
        <div class="container">
            <div class="row no-gutters slider-text align-items-center justify-content-center">
                <div class="col-md-9 ftco-animate text-center">
                    <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span>Checkout</span></p>
                    <h1 class="mb-0 bread">Checkout</h1>
                </div>
            </div>
        </div>
    </div>

    <section class="ftco-section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-xl-7 ftco-animate">
                    <form action="#" class="billing-form">
                        <h3 class="mb-4 billing-heading">Billing Details</h3>
                        <div class="row align-items-end">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="firstname">Firt Name</label>
                                    <input type="text" class="form-control" placeholder="" runat="server" id="first_name">
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="lastname">Last Name</label>
                                    <input type="text" class="form-control" placeholder="" runat="server" id="last_name">
                                </div>
                            </div>
                            <div class="w-100"></div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label for="country">Address</label>
                                    <input type="text" class="form-control" id="address" runat="server" />
                                </div>
                            </div>
                            <div class="w-100"></div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="phone">Phone</label>
                                    <input type="text" class="form-control" placeholder="" id="phone" runat="server">
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label for="emailaddress">Email Address</label>
                                    <input type="text" class="form-control" placeholder="" id="email" runat="server">
                                </div>
                            </div>
                        </div>
                    </form>
                    <!-- END -->
                </div>
                <div class="col-xl-5">
                    <div class="row mt-5 pt-3">
                        <div class="col-md-12 d-flex mb-5">
                            <div class="cart-detail cart-total p-3 p-md-4">
                                <h3 class="billing-heading mb-4">Cart Total</h3>
                                <p class="d-flex">
                                    <span>Subtotal</span>
                                    <span id="subtotal" runat="server"></span>
                                </p>
                                <p class="d-flex">
                                    <span>Delivery</span>
                                    <span id="delivery" runat="server"></span>
                                </p>
                                <p class="d-flex">
                                    <span>Vat</span>
                                    <span id="vat" runat="server"></span>
                                </p>
                                <p class="d-flex">
                                    <span>Discount</span>
                                    <span id="discount" runat="server"></span>
                                </p>
                                <hr>
                                <p class="d-flex total-price">
                                    <span>Total</span>
                                    <span id="total" runat="server"></span>
                                </p>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="cart-detail p-3 p-md-4">    
                                <p><a id="invoicebutton" class="btn btn-primary py-3 px-4" onserverclick="GenerateInvoice" runat="server">Place an order</a></p>
                            </div>
                        </div>
                    </div>
                </div>  
            </div>
        </div>
    </section>

</asp:Content>
