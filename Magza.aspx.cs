using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magza_urun_takip
{
    public partial class Magza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear(); //liste her seferinde sıfırlansın yeni istekelri göstersin diye yaptık

            int adet = Convert.ToInt32(Interaction.InputBox("ÜRÜN SAYISINI GİRİN:"));
            Urun[] urunlerim = new Urun[adet];

            int sayac = 0;
            for (int i = 0; i < adet; i++)
            {
                Urun yeni_urun = new Urun();
                yeni_urun.barkodNO = Convert.ToInt32(Interaction.InputBox("Ürün barkodunu giriniz:"));
                yeni_urun.urun_ad = Interaction.InputBox("Ürün adı giriniz:");
                yeni_urun.kate = Interaction.InputBox("Ürün kategorisi giriniz:");
                yeni_urun.fiyat = Convert.ToDouble(Interaction.InputBox("Ürün fiyatını giriniz:"));
                urunlerim[i] = yeni_urun;
                sayac++;
                int cev = Convert.ToByte(Interaction.MsgBox("Devam edilsin mi ?", MsgBoxStyle.YesNo));
                if (cev == 7) break;
            }
            Array.Resize(ref urunlerim, sayac);
            byte secim = Convert.ToByte(Interaction.InputBox("Ne yapmak istiyorsun?\n 1-tüm ürünleri listele\n 2-Aradığın ürünün kategorisine göre ürün listelme\n 3-Min fiyata eşit veya büyük olan ürünleri listele "));
            switch (secim)
            {
                case 1:
                    foreach (Urun gelen_urun in urunlerim)
                    {
                        ListBox1.Items.Add(gelen_urun.urun_bilgisi_ver());
                    }

                    break;
                case 2:
                    string kate_ad = Interaction.InputBox("Aradığınız ürünün kategorisini giriniz:");
                    foreach (Urun gelen_urun in urunlerim)
                    {
                        if (gelen_urun.kate == kate_ad) ListBox1.Items.Add(gelen_urun.urun_bilgisi_ver());
                    }
                    break;
                case 3:
                    double min_fiyat = Convert.ToDouble(Interaction.InputBox("min fiyat giriniz:"));
                    foreach (Urun gelen_urun in urunlerim)
                    {
                        if (gelen_urun.fiyat >= min_fiyat) ListBox1.Items.Add(gelen_urun.urun_bilgisi_ver());
                    }
                    break;
            }
        }
    }
}