using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace oyunuyorumWebApp.AdminPanel
{
    public partial class YoneticiEkle : System.Web.UI.Page
    {
        VeriModeli db = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void lbtn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                if (!string.IsNullOrEmpty(tb_soyisim.Text))
                {
                    if (!string.IsNullOrEmpty(tb_email.Text))
                    {
                        if (!string.IsNullOrEmpty(tb_sifre.Text))
                        {
                            if (!string.IsNullOrEmpty(tb_isim.Text))
                            {
                                Yonetici y = new Yonetici();
                                y.Isim = tb_isim.Text;
                                y.Soyisim = tb_soyisim.Text;
                                y.Sifre = tb_sifre.Text;
                                y.YoneticiTur_ID = Convert.ToInt32(ddl_yoneticiturleri.SelectedItem.Value);               
                                y.Email = tb_email.Text;
                                y.KullaniciAdi = tb_kadi.Text;
                                y.Durum = true;
                                if (db.YoneticiEkle(y))
                                {
                                    pnl_basarili.Visible = true;
                                    pnl_basarisiz.Visible = false;
                                }
                                else
                                {
                                    pnl_basarili.Visible = false;
                                    pnl_basarisiz.Visible = true;
                                    lbl_hatamesaj.Text = "Yönetici eklenirken bir hata oluştu";
                                }
                            }
                            else
                            {
                                pnl_basarili.Visible = false;
                                pnl_basarisiz.Visible = true;
                                lbl_hatamesaj.Text = "Yetki boş bırakılamaz.";
                            }



                        }
                        else
                        {
                            pnl_basarili.Visible = false;
                            pnl_basarisiz.Visible = true;
                            lbl_hatamesaj.Text = "Şifre boş bırakılamaz.";
                        }
                    }
                    else
                    {
                        pnl_basarili.Visible = false;
                        pnl_basarisiz.Visible = true;
                        lbl_hatamesaj.Text = "Email boş bırakılamaz.";
                    }



                }
                else
                {
                    pnl_basarili.Visible = false;
                    pnl_basarisiz.Visible = true;
                    lbl_hatamesaj.Text = "Soyisim boş bırakılamaz.";
                }
            }

            else
            {
                pnl_basarili.Visible = false;
                pnl_basarisiz.Visible = true;
                lbl_hatamesaj.Text = "İsim boş bırakılamaz.";
            }
        }
    }
}