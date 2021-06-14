<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="InvoicePage.aspx.cs" Inherits="Farmers_Field_UI.InvoicePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="ftco-section contact-section bg-light">
        <div class="container">
            <div class="row block-9">
                <div class="col-md-6 order-md-last d-flex">
                    <div action="#" class="bg-white p-5 contact-form">
                        <div class="form-group">
                            <input type="text" class="form-control" id="invoiceid" placeholder="Invoice ID" runat="server">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="date" runat="server" visible="false">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="totalsum" runat="server" visible="false">
                        </div>
                        
                        <div class="form-group">
                            <input type="submit" value="Get Invoice" onserverclick="btnInvoice" class="btn btn-primary" runat="server">
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>

</asp:Content>
