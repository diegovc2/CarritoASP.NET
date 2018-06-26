<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="ver_carrito.aspx.cs" Inherits="WebApplication1.home.WebForm3" %>
<asp:Content ID="content1" ContentPlaceHolderID="c1" runat="server">
    <asp:DataList ID="d2" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr style="background-color:silver; color:white; font-weight:bold">
                            <td>Imagen</td>
                            <td>Nombre</td>
                            <td>Precio</td>
                            <td>Descripcion</td>
                            <td>Cantidad</td>
                            <td>Borrar</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>

                     <td>
                         <img src="./<%#Eval("product_img") %>" alt="Alternate Text" />
                     </td>
                    
                        <td>
                     <h1><%#Eval("product_name") %></h1>
                     </td>

                     <td>
                         <h3>$<%#Eval("product_price") %></h3>
                     </td>
                     
                     <td>
                     <p><%#Eval("product_desc") %></p>
                     </td>
                         
                     <td>
                         <p><%#Eval("product_qty") %></p>
                     </td>
                     
                     <td>
                     <a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a>
                    </td>

                        </tr>

                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>

            </asp:DataList>
    <br />
    <p align="center">
    <asp:Label ID="l1" runat="server"></asp:Label> <br />
        <asp:Button Text="Checkout" ID="b1" runat="server" OnClick="b1_Click" />
        </p>

</asp:Content>

