using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application.DTO.DTO;
using WebApp.Application.Interfaces;
using WebApp.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.ApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        private readonly IApplicationServiceVaga _AppserviceVaga;

        public VagasController(IApplicationServiceVaga appserviceVaga)
        {
            _AppserviceVaga = appserviceVaga;
        }

        // GET: api/<VagasController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AppserviceVaga.GetAll());
        }

        // GET api/<VagasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_AppserviceVaga.GetById(id));
        }

        // POST api/<VagasController>
        [HttpPost]
        public void Post(VagaDTO vaga)
        {
            _AppserviceVaga.Add(vaga);
        }

        // PUT api/<VagasController>/5
        [HttpPut]
        public void Put(int id, [FromBody] VagaDTO vagaDTO)
        {
            _AppserviceVaga.Update(vagaDTO);
        }

        // DELETE api/<VagasController>/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _AppserviceVaga.Remove(_AppserviceVaga.GetById(id));
            return RedirectToAction(nameof(Get));
        }
    }
}
