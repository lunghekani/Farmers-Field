<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Farmers_Field_UI.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="ftco-section contact-section bg-light">
        <div class="container">
            <div class="row block-9">
                <div class="col-md-6 order-md-last d-flex">
                    <div action="#" class="bg-white p-5 contact-form">
                        <div class="form-group">
                            <input type="text" class="form-control" id="firstname" placeholder="First Name" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="lastname" placeholder="Last Name" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="email" class="form-control" id="email" placeholder="Email Address" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="number" placeholder="Phone Number" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="aadress" placeholder="Address" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="city" placeholder="City" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="province" placeholder="Province" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="number" class="form-control" id="zip" placeholder="Zip" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" id="pass" placeholder="password" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" id="conf" placeholder="password" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="submit" value="Register" onserverclick="BtnRegister" class="btn btn-primary py-3 px-5" runat="server">
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
</asp:Content>
