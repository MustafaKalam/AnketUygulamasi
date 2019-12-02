using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatListesiAdoNET.DataAccess.Concreate
{
    public class Malzemeler
    {
        public int r_sayac { get; set; }
        public int fiyat_liste_rsayac { get; set; }
        public string liste_adi { get; set; }
        public string malzeme_kodu { get; set; }
        public string malzeme_adi { get; set; }
        public string birim { get; set; }
        public int indirim01_flag { get; set; }
        public int indirim01 { get; set; }
        public string cid { get; set; }
    }
}
