using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Projem.Models
{
    public class Kisi
    {
        public int Id { get; set; }
        [DisplayName("Ad :")]
        public string Adi { get; set; }
        [DisplayName("Soyad: ")]
        public string Soyadi { get; set; }
        [DisplayName("Tc No : ")]
        public long TcNo { get; set; }

        #region Relations
        [DisplayName("İlce :")]
        public string IlceAdi { get; set; }

        public virtual Ilce Ilce { get; set; }

        [DisplayName("Şehir :")]
        public string SehirAdi { get; set; }
        public virtual Sehir Sehir { get; set; }
        #endregion
    }
}