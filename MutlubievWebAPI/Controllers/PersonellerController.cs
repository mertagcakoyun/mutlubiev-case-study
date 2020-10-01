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
    public class PersonellerController : ControllerBase
    {
        [HttpGet]
        public IActionResult PersonelListele()
        {
            using var context = new MutlubievWebApiContext();
            return Ok(context.Personeller.ToList());
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            using var context = new MutlubievWebApiContext();
            context.Personeller.Add(personel);
            context.SaveChanges();

            return Created("", personel);
        }
    }
}
