using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace oyunuyorumWebApp
{
    public partial class UyeOl : System.Web.UI.Page
    {
        VeriModeli db = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbtn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                if (!string.IsNullOrEmpty(tb_soyisim.Text))
                {
                    if (!string.IsNullOrEmpty(tb_email.Text))
                    {
                        if (!string.IsNullOrEmpty(tb_sifre.Text))
                        {
                            Uye u = new Uye();
                            u.Isim = tb_isim.Text;
                            u.Soyisim = tb_soyisim.Text;
                            u.Sifre = tb_sifre.Text;
                            u.Email = tb_email.Text;
                            u.KullaniciAdi = tb_KullaniciAdi.Text;
                            u.Durum = true;
                            u.UyelikTarihi = DateTime.Now;
                            if (db.UyeEkle(u))
                            {
                                pnl_basarili.Visible = true;
                                pnl_basarisiz.Visible = false;
                            }
                            else
                            {
                                pnl_basarili.Visible = false;
                                pnl_basarisiz.Visible = true;
                                lbl_hatamesaj.Text = "Üye eklenirken bir hata oluştu.";
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