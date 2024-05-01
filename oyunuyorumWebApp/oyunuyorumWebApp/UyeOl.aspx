<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UyeOl.aspx.cs" Inherits="oyunuyorumWebApp.UyeOl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="girisKutu">
        <div class="baslik">
            <h2>Hoş Geldin Oyuncu</h2>
            <h3>Üye Ol</h3>
        </div>
        <div class="girisForm">
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisizpanel" Visible="false">
                <asp:Label ID="lbl_hatamesaj" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                <label>Üyelik oluşmuştur.</label>
            </asp:Panel>
            <div class="satir">
                <asp:TextBox ID="tb_isim" runat="server" CssClass="formMetinKutu" placeholder="Adınız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_soyisim" runat="server" CssClass="formMetinKutu" placeholder="Soyadınız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_KullaniciAdi" runat="server" CssClass="formMetinKutu" placeholder="Kullanıcı Adınız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_email" runat="server" CssClass="formMetinKutu" placeholder="Emailiniz"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_sifre" TextMode="Password" runat="server" CssClass="formMetinKutu" placeholder="Şifreniz"></asp:TextBox>
            </div>
        </div>
        <div class="satir" style="margin-top: 20px">
            <asp:LinkButton ID="lbtn_giris" runat="server" OnClick="lbtn_giris_Click" CssClass="formGirisButon">Üye Ol</asp:LinkButton>
        </div>

    </div>
</asp:Content>
