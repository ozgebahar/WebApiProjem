using Projem.IlceVeri;
using Projem.KisiVeri;
using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projem.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        public ActionResult KisiListele()
        {
            return View(KisiData.KisiList);
        }

      

        // GET: Kisi/Create
        public ActionResult KisiEkle()
        {
            return View();
        }

        // POST: Kisi/Create
        [HttpPost]
        public ActionResult KisiEkle(Kisi yeniKisi)
        {
            try
            {
                Kisi eklenecekKisi = new Kisi()
                {
                    Adi = yeniKisi.Adi,
                    Soyadi = yeniKisi.Soyadi,
                    TcNo = yeniKisi.TcNo,
                    SehirAdi = yeniKisi.SehirAdi,
                    IlceAdi = yeniKisi.IlceAdi
                };

                KisiData.KisiList.Add(eklenecekKisi);

                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
