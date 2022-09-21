using Projem.KisiVeri;
using Projem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projem.Controllers
{
    public class KisiApiController : ApiController
    {
        // GET: api/KisiApi
        public IEnumerable<Kisi> Get()
        {
            return KisiData.KisiList;
        }

        // GET: api/KisiApi/5
        public IHttpActionResult Get(int id)
        {
            var arananKisi = (KisiData.KisiList.Where(u => u.Id == id)).FirstOrDefault();
            if (arananKisi == null)
            {
                return NotFound();
            }
            else
                return Ok(arananKisi);
        }

        // POST: api/KisiApi
        [HttpPost]
        public IHttpActionResult Post([FromBody] Kisi yeniKisi)
        {
            var kisiAdi = yeniKisi != null ? yeniKisi.Adi : "";
            var kisiSoyadi = yeniKisi != null ? yeniKisi.Soyadi : "";
            var tcNo = yeniKisi?.TcNo ?? 0;
            var ilceAdi = yeniKisi != null ? yeniKisi.IlceAdi : "";
            var sehirAdi = yeniKisi != null ? yeniKisi.SehirAdi : "";
            KisiData.KisiList.Add(yeniKisi);
            return Ok(kisiAdi);

        }

        // PUT: api/KisiApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KisiApi/5
        public void Delete(int id)
        {
        }
    }
}
