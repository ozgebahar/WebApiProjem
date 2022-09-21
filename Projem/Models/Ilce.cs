using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Projem.Models
{
    public class Ilce
    {
        public int Id { get; set; }

        [DisplayName("İlçe :")]
        public string Adi { get; set; }

        [DisplayName("Şehir :")]
        public string SehirAdi { get; set; }

        #region Relations
        public virtual Sehir Sehir { get; set; }

        public ICollection<Kisi> Kisiler { get; set; } 
        #endregion
    }
}