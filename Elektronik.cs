using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknosa
{
  public class Elektronik
    {
        public string model { get; set; }
        public string marka { get; set; }
        public string renk { get; set; }
        public string üretimyeri { get; set; }
        public int fiyat { get; set; }

        public Elektronik(string Model,string Marka,string Renk,string Üretimyeri,int Fiyat)
        {
            this.model = Model;
            this.marka = Marka;
            this.renk = Renk;
            this.üretimyeri = Üretimyeri;
            this.fiyat = Fiyat;
        }
        public virtual void bilgiVer()
        {
            Console.WriteLine("Temel metot çalıştı");
        }
    }
}
