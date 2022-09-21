using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projem.Models
{
    public class Sehir
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        #region Relations
        public ICollection<Ilce> Ilceler { get; set; }
        public ICollection<Kisi> Kisiler { get; set; } 
        #endregion
    }
}