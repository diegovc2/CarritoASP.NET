<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="prod_desc.aspx.cs" Inherits="WebApplication1.home.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
      
        
    <asp:Repeater runat="server" ID="d1" runat="server" OnItemCommand="d1_ItemCommand">
        <HeaderTemplate>

                      
            <div class="row">
              
        </HeaderTemplate>
        <ItemTemplate >
            
                 <div class="col-lg-4 col-md-6 mb-4">
                     <img src="./<%#Eval("img") %>" alt="Alternate Text" />

                 </div>
                 <div class="col-lg-4 col-md-6 mb-4">
                     <h1><%#Eval("title") %></h1>
                     <p><%#Eval("desc") %></p>
                     <h3>$<%#Eval("price") %></h3>
                     <h3>Cantidad disponible: <%#Eval("qty") %></h3>

                    
                 </div>

        </ItemTemplate>

        <FooterTemplate>

              </div>
        </FooterTemplate> 
            
       </asp:Repeater>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="l2" runat="server" Text="Ingresar Cantidad" > </asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="t1" />

                    </td>
                   
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="l1" runat="server" ForeColor="Red" Text=""></asp:Label>

                    </td>
                </tr>
                <tr>
                     <td>
                       <asp:Button ID="b1" Text="Agregar al carrito" CssClass="btn btn-info btn-lg" runat="server" OnClick="Unnamed1_Click" />

                    </td>
                </tr>
            </table>

</asp:Content>
