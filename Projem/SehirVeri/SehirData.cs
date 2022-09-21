using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projem.SehirVeri
{
    public class SehirData
    {
        public static List<Sehir> SehirList = new List<Sehir>()
        {
            new Sehir
            {
            Id=1,
            Adi="Ankara"
            },

            new Sehir
            {
                Id=2,
                Adi="Adana"
            }

        };
    }
}