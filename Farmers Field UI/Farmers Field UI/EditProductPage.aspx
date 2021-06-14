<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="EditProductPage.aspx.cs" Inherits="Farmers_Field_UI.EditProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <section class="ftco-section contact-section bg-light">

         <div class="container">

             <div class="row block-9">
                 <div class="col-md-6 order-md-last d-flex">

                     <div  action="#" class="bg-white p-5 contact-form">
                          <div class="form-group">
                             <input type="text" class="form-control" id="pro_ID" placeholder="Product ID" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Name" placeholder="Product Name" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Category" placeholder="Product category" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Description" placeholder="Product Description" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Discount" placeholder="Product Discount" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Price" placeholder="Product Price" runat="server">
                         </div>

                         <div class="form-group">
                             <input type="text" class="form-control" id="Pro_Supplier" placeholder="Product Supplier" runat="server">
                         </div>

                          <div class="form-group">
                              <asp:Button type="submit" ID="btnSubmitEdit" runat="server" Text="Submit" class="btn btn-primary py-3 px-5" OnClick="btnSubmitEdit_Click" />
                         </div>

                          <div id="Add_Status" runat="server">
                            <h5>Successfully Edited </h5>
                        </div>

                      </div>

                 </div>

             </div>
         </div>


    </section>

</asp:Content>
