using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public int Makale_ID { get; set; }
        public int Uye_ID { get; set; }
        public string Uye {  get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
    }
}
