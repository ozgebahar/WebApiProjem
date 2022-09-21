using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projem.IlceVeri
{
    public class IlceData
    {
        public static List<Ilce> IlceList = new List<Ilce>()
        {
            new Ilce
            {
            Id=1,
            Adi="Çankaya",
            SehirAdi= SehirVeri.SehirData.SehirList[0].Adi
            },

            new Ilce
            {
                Id=2,
                Adi="Seyhan",
                SehirAdi= SehirVeri.SehirData.SehirList[1].Adi
            }

        };
    }
}