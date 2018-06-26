<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="pagocompleto.aspx.cs" Inherits="WebApplication1.home.pagocompleto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Panel runat="server" ID="panelPDF">
    <asp:DataList ID="d2" runat="server" >
                <HeaderTemplate>
                    <table>
                        <tr style="background-color:silver; color:white; font-weight:bold">
                            <td>Nombre</td>
                            <td>Precio</td>
                            <td>Descripcion</td>
                            <td>Cantidad</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>

                     
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
                     
                     

                        </tr>

                </ItemTemplate>
                <FooterTemplate>
                            </table>

                    </FooterTemplate>

                </asp:DataList>

                    <p>Total: <asp:Label name="l1" ID="l1"  runat="server" /></p> 
                    <p> Medio de Pago: <asp:Label name="l2" ID="l2" runat="server"/></p>

    
        </asp:Panel>
    <br />
    <br />
            <asp:Button runat="server" ID="btnPrint" Text="Imprimir" OnClick="btnPrint_Click" />
</asp:Content>
