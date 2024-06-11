
<%@ Page Title="" Language="C#" MasterPageFile="~/View/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="GoceryStoreManagement.View.Seller.Billing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script>
         function printpage() {
             window.print();
         }
     </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
       <div class="row">
            <div class="col-md-5">
                <div class="row">
                    <div class="col">
                        <div class="mb-3 ">
                    <label for="exampleInputEmail1" class="form-label">Product Name</label>
                    <input type="text" class="form-control" id="ProName" runat="server" required="required"/>
                       </div>

                         <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Price</label>
                    <input type="text" class="form-control" id="ProPice" runat="server" required="required"/>
                       </div>

                         <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Quantity</label>
                    <input type="text" class="form-control" id="ProQuantity" runat="server" required="required"/>
                       </div>

                    </div>
                    <div class="col">
                        <br />
                        <img src="../../Asset/Images/bill (2) (1).png" />
                        <br />
                        <br />
                     <label id="ErrMsg" runat="server" class="text-danger"></label>
                        <br />

                     <asp:Button Text="Add to bill " class="btn btn-warning" runat="server" ID="AddToBill" OnClick="AddToBill_Click"  />
                     <asp:Button Text=" Reset " class="btn btn-danger" runat="server" ID="ResetBtn" />
                </div>
                </div>

                

                <div class="row">
                    <div class="col">
                        <asp:GridView ID="GridView1" runat="server" class="table table-danger table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

                          </asp:GridView>

                    </div>


                </div>
            </div>
           <div class="col-md-7 ">
               <div class="row">
                  <div class="col-3"></div>
                   <div class="col"> <h1 class="text-warning pl-2">Client Billing</h1></div>

               </div>
               <div class="row">
                   <div id="DivToPrint" runat="server">
                   <asp:GridView id="BillGV" runat="server" class="table">

                   </asp:GridView>
                  </div>

               </div>
               <div class="row">
                   <div class="col"></div>
                   <div class="col"><h3 id="GrdToTb" class="text-danger" runat="server"></h3></div>
                   <div class="col d-gird"><asp:Button Text=" Print Bill "  OnClientClick="printpage()" class="btn btn-warning btn-block text-white-50" runat="server" ID="PrintBtn"  OnClick="PrintBtn_Click1" />
                       <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/Login.aspx">Go To HomePage</asp:HyperLink>
                   </div>
               </div>
           </div>
       </div>
   </div>
</asp:Content>
