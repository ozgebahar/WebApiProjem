using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projem.KisiVeri
{
    public class KisiData
    {
        public static List<Kisi> KisiList = new List<Kisi>()
        {
            new Kisi
            {
            Id =1,
            Adi= "Özge Bahar",
            Soyadi ="Taşbaş",
            TcNo= 12345678912,
            SehirAdi = SehirVeri.SehirData.SehirList[0].Adi,
            IlceAdi = IlceVeri.IlceData.IlceList[0].Adi

            }
        };
    }
}