<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Product-Single.aspx.cs" Inherits="Farmers_Field_UI.Product_Single" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="hero-wrap hero-bread" style="background-image: url('images/jake-gard-CetB-bTDBtY-unsplash (4).jpg');">
        <div class="container">
            <div class="row no-gutters slider-text align-items-center justify-content-center">
                <div class="col-md-9 ftco-animate text-center">
                    <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span class="mr-2"><a href="index.html">Product</a></span> <span>Product Single</span></p>
                    <h1 class="mb-0 bread">Product</h1>
                </div>
            </div>
        </div>
    </div>

    <section class="ftco-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 mb-5 ftco-animate" id="productimage" runat="server">
                </div>
                <div class="col-lg-6 product-details pl-md-5 ftco-animate" id="singleproduct" runat="server">
                </div>
            </div>
        </div>
    </section>


</asp:Content>
