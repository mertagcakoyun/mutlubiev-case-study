using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MutlubievWebAPI.DAL.Context;
using MutlubievWebAPI.DAL.Entities;

namespace MutlubievWebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class HizmetlerController : ControllerBase
    {
        [HttpGet]
        public IActionResult HizmetListele()
        {
            using var context = new MutlubievWebApiContext();
            return Ok(context.Hizmetler.ToList());
        }
        
        [HttpPut]
        public IActionResult HizmetGuncelle(Hizmet hizmet)
        {
            using var context = new MutlubievWebApiContext();
            var guncelHizmet = context.Hizmetler.Find(hizmet.Id);
            if (guncelHizmet == null)
            {
                return NotFound();
            }
            guncelHizmet.HizmetAdi = hizmet.HizmetAdi;
            guncelHizmet.HizmetAciklama = hizmet.HizmetAciklama;
            context.Update(guncelHizmet);
            context.SaveChanges();
            return NoContent();
        }
        
        [HttpPost]
        public IActionResult HizmetEkle(Hizmet hizmet)
        {
            using var context = new MutlubievWebApiContext();
            context.Hizmetler.Add(hizmet);
            context.SaveChanges();

            return Created("", hizmet);
        }

    }
}
