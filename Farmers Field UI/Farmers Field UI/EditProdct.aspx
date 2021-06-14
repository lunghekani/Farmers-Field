<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="EditProdct.aspx.cs" Inherits="Farmers_Field_UI.EditProdct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <header>
             <h1>Edit Product</h1>
     </header>

     <section class="ftco-section contact-section bg-light">
                 <div class="container">

             <div class="row block-9">
                 <div class="col-md-6 order-md-last d-flex">

                     <div  action="#" class="bg-white p-5 contact-form">

                           <div class="form-group">
                             <input type="text" class="form-control" id="pro_ID" placeholder="Product ID" runat="server">
                         </div>
                          <div class="form-group">
                              <asp:Button type="submit" ID="btnFind" runat="server" Text="Search" class="btn btn-primary py-3 px-5" OnClick="btnFind_Click" />
                              
                          </div>

                         </div>
                     </div>
                 </div>
                     </div>

         </section>



</asp:Content>
