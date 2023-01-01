using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknosa
{
    public class Tv:Elektronik
    {
        public int stokAdedi { get; set; }
        public string ekranBoyutu { get; set; }
        public bool wifiVarMi { get; set; }

        public int satisYap()
        {
            this.stokAdedi--;
            return this.stokAdedi;
        }
        public int stokEkle()
        {
            this.stokAdedi++;
            return this.stokAdedi;    
            
        }
        public override void bilgiVer()
        {
            Console.WriteLine("Stok adeedi= " + stokAdedi);
        }
        public Tv(string Model, string Marka, string Renk,string Üretimyeri, int Fiyat) : base(Model,Marka,Renk,Üretimyeri,Fiyat)
        {
            this.stokEkle();
        
            this.bilgiVer();    

        }
    }

}
