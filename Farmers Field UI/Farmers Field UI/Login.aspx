<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Farmers_Field_UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <section class="ftco-section contact-section bg-light">
      <div class="container">
          <div class="row block-9">
            <div class="col-md-6 order-md-last d-flex">
            <div action="#" class="bg-white p-5 contact-form">
              <div class="form-group">
                <input type="text" class="form-control" id="username" placeholder="Your email" runat="server">
              </div>
              <div class="form-group">
                <input type="password" class="form-control" id="pass" placeholder="Your password" runat="server">
              </div>
              <div class="form-group">
                <input type="submit" value="Login"  onserverclick="btnLogin_Click" class="btn btn-primary" runat="server">
                <input type="submit" value="Sign up?"  onserverclick="btnRegister_Click" class="btn btn-info" runat="server">
              </div>
            </div>    
          </div>
        </div>
      </div>

    </section>

</asp:Content>
