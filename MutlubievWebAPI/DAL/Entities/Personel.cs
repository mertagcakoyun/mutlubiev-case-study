using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutlubievWebAPI.DAL.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string İl { get; set; }
        public string İlce { get; set; }
        public string Cinsiyet { get; set; }
    }
}
