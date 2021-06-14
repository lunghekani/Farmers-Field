<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Farmers_Field_UI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="home-section" class="hero">
        <div class="home-slider owl-carousel">
            <div class="slider-item" style="background-image: url(images/nathan-fertig-HZUIr4kkvvE-unsplash.jpg);">
                <div class="overlay"></div>
                <div class="container">
                    <div class="row slider-text justify-content-center align-items-center" data-scrollax-parent="true">

                        <div class="col-md-12 ftco-animate text-center">
                            <h1 class="mb-2">WE SERVE QUALITY LIVESTOCK PRODUCTS</h1>
                            <h2 class="subheading mb-4">We deliver livestock food, medication &amp; machinery</h2>
                        </div>
                    </div>
                </div>
            </div>

            <div class="slider-item" style="background-image: url(images/nathan-fertig-HZUIr4kkvvE-unsplash.jpg);">
                <div class="overlay"></div>
                <div class="container">
                    <div class="row slider-text justify-content-center align-items-center" data-scrollax-parent="true">

                        <div class="col-sm-12 ftco-animate text-center">
                            <h1 class="mb-2">GIVE THEM A HEALTHY LIFE</h1>
                            <h2 class="subheading mb-4">We deliver livestock food, medication &amp; machinery</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="ftco-section">
        <div class="container">
            <div class="row no-gutters ftco-services">
                <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
                    <div class="media block-6 services mb-md-0 mb-4">
                        <div class="icon bg-color-1 active d-flex justify-content-center align-items-center mb-2">
                            <span class="flaticon-shipped"></span>
                        </div>
                        <div class="media-body">
                            <h3 class="heading">Free Shipping</h3>
                            <span>On order over R1000.00</span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
                    <div class="media block-6 services mb-md-0 mb-4">
                        <div class="icon bg-color-2 d-flex justify-content-center align-items-center mb-2">
                            <span class="flaticon-diet"></span>
                        </div>
                        <div class="media-body">
                            <h3 class="heading">Always Fresh</h3>
                            <span>Product well package</span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
                    <div class="media block-6 services mb-md-0 mb-4">
                        <div class="icon bg-color-3 d-flex justify-content-center align-items-center mb-2">
                            <span class="flaticon-award"></span>
                        </div>
                        <div class="media-body">
                            <h3 class="heading">Superior Quality</h3>
                            <span>Quality Products</span>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
                    <div class="media block-6 services mb-md-0 mb-4">
                        <div class="icon bg-color-4 d-flex justify-content-center align-items-center mb-2">
                            <span class="flaticon-customer-service"></span>
                        </div>
                        <div class="media-body">
                            <h3 class="heading">Support</h3>
                            <span>24/7 Support</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="ftco-section ftco-category ftco-no-pt">
        <div class="container">
            <div class="row">
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-6 order-md-last align-items-stretch d-flex">
                            <div class="category-wrap-2 ftco-animate img align-self-stretch d-flex" style="background-image: url(images/Animals-Cow-hd-wallpapers.jpg);">
                                <div class="text text-center">
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                      <br />
                                      <br />
                                      
                                    <p style="color:White;">Give Them A Healthy Lifestyle</p>
                                    <p><a href="Shop.aspx" class="btn btn-primary">Shop now</a></p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="category-wrap ftco-animate img mb-4 d-flex align-items-end" style="background-image: url(images/nutrebeef.jpg);">
                                <div class="text px-3 py-1">
                                    <h2 class="mb-0"><a href="Shop.aspx">Foods</a></h2>
                                </div>
                            </div>
                            <div class="category-wrap ftco-animate img d-flex align-items-end" style="background-image: url(images/ver.jpg);">
                                <div class="text px-3 py-1">
                                    <h2 class="mb-0"><a href="Shop.aspx">Machinery</a></h2>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="category-wrap ftco-animate img mb-4 d-flex align-items-end" style="background-image: url(images/VetandCow_Banner.jpg);">
                        <div class="text px-3 py-1">
                            <h2 class="mb-0"><a href="Shop.aspx">Medication</a></h2>
                        </div>
                    </div>
                    <div class="category-wrap ftco-animate img d-flex align-items-end" style="background-image: url(images/abcd.jpg);">
                        <div class="text px-3 py-1">
                            <h2 class="mb-0"><a href="Shop.aspx">Others</a></h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

     <section class="ftco-section testimony-section">
        <div class="container">
            <div class="row justify-content-center mb-5 pb-3">
                <div class="col-md-7 heading-section ftco-animate text-center">
                    <h2 class="mb-4">A Word From The Rametses</h2>
                    <p>"Farmer's Field is Farmer's Paradise."<br />
                        -Norman Rametse (McDonalds South Africa Poultry Supplier)
                    </p>
                </div>
            </div>
           
        </div>
    </section>


    <section class="ftco-section img" style="background-image: url(images/fence-918535_1920.jpg);">
        <div class="container">
            <div class="row justify-content-end">
                <div class="col-md-6 heading-section ftco-animate deal-of-the-day ftco-animate">
                    <h2 class="mb-4">Deal of the day</h2>               
                    <h3><a href="#">Cydectin Injectible</a></h3>
                    <span class="price">R180 <a href="#">now R90 only</a></span>
                    <div id="timer" class="d-flex mt-5">
                        <div class="time" id="days"></div>
                        <div class="time pl-3" id="hours"></div>
                        <div class="time pl-3" id="minutes"></div>
                        <div class="time pl-3" id="seconds"></div>
                    </div>
                </div>
            </div>
        </div>
    </section>

   

    <hr>

</asp:Content>
