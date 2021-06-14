<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="Farmers_Field_UI.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="hero-wrap hero-bread" style="background-image: url('images/jake-gard-CetB-bTDBtY-unsplash (4).jpg');">
        <div class="container">
            <div class="row no-gutters slider-text align-items-center justify-content-center">
                <div class="col-md-9 ftco-animate text-center">
                    <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span>Products</span></p>
                    <h1 class="mb-0 bread">Products</h1>
                </div>
            </div>
        </div>
    </div>


    <section class="ftco-section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-10 mb-5 text-center">
                    <ul class="product-category">
                        <li><a href="#" onserverclick="btnAll" runat="server">All products </a></li>
                        <li><a onserverclick="btnFood" runat="server">Foods </a></li>
                        <li><a onserverclick="btnMachinary" runat="server">Machinery </a></li>
                        <li><a onserverclick="btnMeds" runat="server">Medication </a></li>
                    </ul>
                </div>
            </div>
            <div class="row" id="shopproducts" runat="server">
            </div>
        </div>
    </section>
</asp:Content>
