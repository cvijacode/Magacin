<%@ Page Title="Dodavanje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dodavanje.aspx.cs" Inherits="Magacin.Dodavanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table style="width: 100%;">
        <tr>
            <td style="width: 150px; height: 20px;">Bar kod:</td>
            <td style="height: 20px; width: 200px">
                <asp:TextBox ID="txtBarKod" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 150px">Naziv:</td>
            <td class="modal-sm" style="width: 200px">
                <asp:TextBox ID="txtNaziv" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Vrsta:</td>
            <td class="modal-sm" style="width: 200px">
                <asp:TextBox ID="txtVrsta" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Jedinica mere:</td>
            <td class="modal-sm" style="width: 200px">
                <asp:TextBox ID="txtJedinicaMere" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Cena:</td>
            <td class="modal-sm" style="width: 200px">
                <asp:TextBox ID="txtCena" runat="server" Width="190px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">&nbsp;</td>
            <td class="modal-sm" style="width: 200px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">
                <asp:Button ID="btnSacuvaj" runat="server" OnClick="btnSacuvaj_Click" Text="Sačuvaj" />
            </td>
            <td class="modal-sm" style="width: 200px">
                <asp:Button ID="btnOdustani" runat="server" OnClick="btnOdustani_Click" Text="Odustani" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
