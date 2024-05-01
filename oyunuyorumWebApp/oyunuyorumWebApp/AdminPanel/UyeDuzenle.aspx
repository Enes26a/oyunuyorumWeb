<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="UyeDuzenle.aspx.cs" Inherits="oyunuyorumWebApp.AdminPanel.UyeDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="formTasiyici">
    <div class="formBaslik">
        <h3>Uye Düzenle</h3>
    </div>
    <div class="formIcerik">
        <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisizpanel" Visible="false">
            <asp:Label ID="lbl_hatamesaj" runat="server"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
            <label>Üye başarıyla düzenlenmiştir</label>
        </asp:Panel>
        <div class="satir">
            <label class="formetiket">Adı</label>
            <asp:TextBox ID="tb_isim" runat="server" CssClass="metinkutu"></asp:TextBox>
        </div>
        <div class="satir">
            <label class="formetiket">Soyadı</label>
            <asp:TextBox ID="tb_soyisim" runat="server" CssClass="metinkutu"></asp:TextBox>
        </div>
        <div class="satir">
    <label class="formetiket">Kullanıcı Adı</label>
    <asp:TextBox ID="tb_kadi" runat="server" CssClass="metinkutu"></asp:TextBox>
        </div>
        <div class="satir">
    <label class="formetiket">Email</label>
    <asp:TextBox ID="tb_email" runat="server" CssClass="metinkutu"></asp:TextBox>
      </div>
        <div class="satir">
    <label class="formetiket">Şifre</label>
    <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinkutu"></asp:TextBox>
      </div>
        <div class="satir">
             <label class="formetiket">Yasak Durumu</label>
            <asp:CheckBox ID="cb_durum" runat="server" Text=" Yayınla" />
            <small style="color:dimgray">(Eğer işaretli değil ise üye yasaklanır.)</small>
        </div>
        <div class="satir">
            <asp:Button ID="lbtn_duzenle" runat="server" CssClass="formButton" Text="Üye Düzenle" OnClick="lbtn_duzenle_Click"/>
        </div>
    </div>
</div>
</asp:Content>
