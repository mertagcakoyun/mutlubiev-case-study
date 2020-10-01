using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutlubievWebAPI.DAL.Entities
{
    public class Hizmet
    {
        public int Id { get; set; }
        public string HizmetAdi { get; set; }
        public string HizmetAciklama { get; set; }
    }
}
