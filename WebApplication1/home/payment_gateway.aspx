<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="payment_gateway.aspx.cs" Inherits="WebApplication1.home.payment_gateway2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">


    <p>Total:</p> 

    <h3>$<asp:label ID="l1" runat="server" /></h3>

    <br />
    <h3>Elegir medio de pago:</h3>
    <table>
        <tr>
            <asp:RadioButtonList ID="tipo" runat="server">
                <asp:ListItem Text="Tarjeta de Crédito" />
                <asp:ListItem Text="Paypal" />
                <asp:ListItem Text="Otros Medios" />
            </asp:RadioButtonList>
            

        </tr>
        
    </table>
    <br />
    <asp:Button ID="b1" text="Terminar Compra" runat="server" OnClick="b1_Click" />


</asp:Content>
