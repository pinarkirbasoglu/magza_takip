using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace magza_urun_takip
{
    public class Urun
    {
        public string urun_ad;
        public int barkodNO;
        public string kate;
        public double fiyat;

        public string urun_bilgisi_ver()
        {
            return "Barkod no :" + " " + barkodNO + "\n" + "Ürün adı: " + " " + urun_ad + "\n" + "Ürün kategorisi: " + kate + "\n" + "Ürün fiyatı :" + " " + fiyat;
        }
    }
}