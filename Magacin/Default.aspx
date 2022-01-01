<%@ Page Title="Početna" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Magacin._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
    th, tr
    {
        text-align:center;
    }
    </style>

    <br />
    <asp:GridView ID="grdProizvodi" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowCommand="grdProizvodi_RowCommand" Width="700px" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" >
        <Columns>
            <asp:BoundField DataField="BarKod" HeaderText="Bar kod" />
            <asp:BoundField DataField="Naziv" HeaderText="Naziv" />
            <asp:BoundField DataField="Vrsta" HeaderText="Vrsta" />
            <asp:BoundField DataField="JedinicaMere" HeaderText="Jed. mere" />
            <asp:BoundField DataField="Cena" HeaderText="Cena" />
            <asp:ButtonField CommandName="Izmena" Text="Izmena" />
            <asp:ButtonField CommandName="Brisanje" Text="Brisanje" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>

    <br />
    <asp:Button ID="btnDodaj" runat="server" Text="Dodaj novi proizvod!" OnClick="btnDodaj_Click" />

</asp:Content>
