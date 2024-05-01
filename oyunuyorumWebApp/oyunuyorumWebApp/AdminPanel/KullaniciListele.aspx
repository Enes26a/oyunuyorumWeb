<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="KullaniciListele.aspx.cs" Inherits="oyunuyorumWebApp.AdminPanel.KullaniciListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
    <div class="formBaslik">
        <h3>Kullanıcılar</h3>
    </div>
    <asp:ListView ID="lv_uyeler" runat="server" OnItemCommand="lv_uyeler_ItemCommand">
        <LayoutTemplate>
            <table cellpadding="0" cellspacing="0" class="tablo">
                <tr>
                    <th style="text-align:center">ID</th>
                    <th>Isim</th>
                    <th>Soyisim</th>
                    <th>Kullanici Adi</th>
                    <th>Email</th>
                    <th>Sifre</th>
                    <th>Durum</th>
                </tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td align="center"><%# Eval("ID") %></td>
                <td><%# Eval("Isim") %></td>
                <td><%# Eval("Soyisim") %></td>
                <td><%# Eval("KullaniciAdi") %></td>
                <td><%# Eval("Email") %></td>
                <td><%# Eval("Sifre") %></td>
                <td><%# Eval("Durum") %></td>
                <td>
                    <a href='UyeDuzenle.aspx?kategoriID=<%# Eval("ID") %>' class="tablebuttonduzenle">Düzenle</a>
                    <asp:LinkButton ID="lbtn_sil" runat="server" CssClass="tablebuttonsil" CommandArgument='<%# Eval("ID") %>' CommandName="sil">Sil</asp:LinkButton>
                     <asp:LinkButton ID="lbtn_durum" runat="server" CssClass="tablebuttondurum" CommandArgument='<%# Eval("ID") %>' CommandName="durum">Durum Değiştir</asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</div>
</asp:Content>
