using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_otomasyonu_777
{
    internal class Film
    {
       public int Id { get; set; }
       public string Ad { get; set; }
       public int sure { get; set; }
       public DateTime izlemeTarih { get; set; }
       public string tur { get; set; }
       public int begen { get; set; }

        //kurucu metot
       
        public Film (int id, string ad,int sure, DateTime tarih, string tur, int puan)
        {
            Id = id;
            Ad = ad;
            sure = sure;
            izlemeTarih = tarih;
            tur = tur;
            begen = puan;
        }

    }
}
