<%@ Page Title="" Language="C#" MasterPageFile="~/home/index.Master" AutoEventWireup="true" CodeBehind="update_order_details.aspx.cs" Inherits="WebApplication1.home.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <table>
        <tr>
            <td>
                Nombre
            </td>
            <td>
                <asp:TextBox runat="server" ID="t1"/>
            </td>
        </tr>

        
        <tr>
            <td>
                RUT
            </td>
            <td>
                <asp:TextBox runat="server" ID="t2"/>
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox runat="server" ID="t3"/>
            </td>
        </tr>
        <tr>
            <td>
                Telefono
            </td>
            <td>
                <asp:TextBox runat="server" ID="t4"/>
            </td>
        </tr>
        <tr>
            <td>
                Direccion
            </td>
            <td>
                <asp:TextBox runat="server" ID="t5"/>
            </td>
        </tr>
        <tr>
            <td>
                Codigo Postal
            </td>
            <td>
                <asp:TextBox runat="server" ID="t6"/>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button Text="Actualizar Datos" runat="server" OnClick="Unnamed1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
 