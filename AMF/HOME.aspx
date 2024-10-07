<%@ Page Language="C#" MasterPageFile="~/TaskManager.Master" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="AMF.HOME" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <br />

 <asp:Panel ID="ImageSliderPanel" runat="server">
     <div class="swiper-container">
         <div class="swiper-wrapper">
             <div class="swiper-slide">
                 <asp:Image ID="Image2" runat="server" Height="330px" Width="1000px" CSSClass="img" ImageAlign="Middle" ImageUrl="~/Images/p1.jpg" />
             </div>
             <div class="swiper-slide">
                 <asp:Image ID="Image3" runat="server" Height="330px" Width="1000px" CSSClass="img" ImageAlign="Middle" ImageUrl="~/Images/p2.jpg" />
             </div>
             <div class="swiper-slide">
                 <asp:Image ID="Image4" runat="server" Height="330px" Width="1000px" CSSClass="img" ImageAlign="Middle" ImageUrl="~/Images/p3.jpeg" />
             </div>
             <div class="swiper-slide">
                 <asp:Image ID="Image5" runat="server" Height="330px" Width="1000px" CSSClass="img" ImageAlign="Middle" ImageUrl="~/Images/p4.jpeg" />
             </div>
         </div>
         <!-- Add Pagination -->
         <div class="swiper-pagination"></div>
         <!-- Add Navigation -->
         <div class="swiper-button-next"></div>
         <div class="swiper-button-prev"></div>
     </div>
 </asp:Panel>

 <!-- Swiper CSS and JS -->
 <link rel="stylesheet" href="https://unpkg.com/swiper/swiper-bundle.min.css" />
 <script src="https://unpkg.com/swiper/swiper-bundle.min.js"></script>

 <script>
     document.addEventListener('DOMContentLoaded', function () {
         var swiper = new Swiper('.swiper-container', {
             loop: true,
             pagination: {
                 el: '.swiper-pagination',
                 clickable: true,
             },
             navigation: {
                 nextEl: '.swiper-button-next',
                 prevEl: '.swiper-button-prev',
             },
         });
     });
 </script>

 <br />

</asp:Content>
