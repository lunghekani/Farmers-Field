<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RemoveProduct.aspx.cs" Inherits="Farmers_Field_UI.GetProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <header>
             <h1>Remove Product</h1>
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
                              <asp:Button type="submit" ID="btnFind" runat="server" Text="Remove" class="btn btn-primary py-3 px-5" OnClick="btnFind_Click" />
                              
                          </div>

                         <div id="Add_Status" runat="server" visible="false">
                            <h5>Successfully Removed </h5>
                        </div>
                         <div id="Div1" runat="server" visible="false">
                            <h5>Removal Unsuccessful</h5>
                        </div>
                         </div>
                     </div>
                 </div>
                     </div>

         </section>
</asp:Content>
