using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using VeriErisimKatmani;

namespace oyunuyorumWebApp.AdminPanel
{
    public partial class UyeDuzenle : System.Web.UI.Page
    {
        VeriModeli dm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["ID"]);
                    Uye u = dm.UyeGetir(id);
                    tb_ad.Text = u.Isim;
                    tb_soyisim.Text = u.Soyisim;
                    tb_kadi.Text = u.KullaniciAdi;
                    tb_email.Text = u.Email;
                    tb_sifre.Text = u.Sifre;
                    cb_durum.Checked = u.Durum;
                }
            }
            else
            {
                Response.Redirect("KullaniciListele.aspx");
            }
        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            Uye u = dm.UyeGetir(id);
            u.Isim = tb_ad.Text;
            u.Soyisim = tb_soyisim.Text;
            u.Sifre = tb_sifre.Text;
            u.Email = tb_email.Text;
            u.KullaniciAdi = tb_kadi.Text;
            u.Durum = true;
            u.UyelikTarihi = DateTime.Now;
            if (dm.UyeDuzenle(u))
            {
                pnl_basarili.Visible = true;
                pnl_basarisiz.Visible = false;
                Session["uye"] = u;
            }
            else
            {
                pnl_basarisiz.Visible = true;
                pnl_basarili.Visible = false;
                lbl_hatamesaj.Text = "Üye düzenlenirken bir hata oluştu";
            }
        }
    }
}