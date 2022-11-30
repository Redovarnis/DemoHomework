using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int Sayfa { get; set; }
        public bool Uygunluk { get; set; }
    }
}
