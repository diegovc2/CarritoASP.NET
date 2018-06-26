<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="repetidor.aspx.cs" Inherits="WebApplication1.home.WebForm1" %>
<asp:Content ID="content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater runat="server" ID="d1" runat="server">
        <HeaderTemplate>

                      
            <div class="row">

        </HeaderTemplate>
        <ItemTemplate>
            <div class="col-lg-4 col-md-6 mb-4">
              <div class="card h-100">
                <a href="prod_desc.aspx?id=<%#Eval("id") %>"><img class="card-img-top" src="./img/<%#Eval("img") %>" alt=""></a>
                <div class="card-body">
                  <h4 class="card-title">
                    <a href="prod_desc.aspx?id=<%#Eval("id") %>"><%#Eval("title") %></a>
                  </h4>
                  <h5>$<%#Eval("price")%></h5>
                    <h5>Cantidad: <%#Eval("qty")%></h5>
                                      <p class="card-text"><%#Eval("desc") %></p>

                    
                </div>
                <div class="card-footer">
                  <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                </div>
              </div>
                 </div>
        </ItemTemplate>
        <FooterTemplate>

                       
            </div>

        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

