using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application.DTO.DTO;
using WebApp.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.ApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnologiaController : ControllerBase
    {
        private readonly IApplicationServiceTecnologia _AppserviceTecnologia;

        public TecnologiaController(IApplicationServiceTecnologia appserviceTecnologia)
        {
            _AppserviceTecnologia = appserviceTecnologia;
        }

        // GET: api/<TecnologiaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AppserviceTecnologia.GetAll());
        }

        // GET api/<TecnologiaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_AppserviceTecnologia.GetById(id));
        }

        // POST api/<TecnologiaController>
        [HttpPost]
        public void Post(TecnologiaDTO value)
        {
            _AppserviceTecnologia.Add(value);
            RedirectToAction(nameof(Index));
        }

        [HttpPut]
        public void Put(TecnologiaDTO tecnologiaDTO)
        {
            _AppserviceTecnologia.Update(tecnologiaDTO);
        }
        
        // DELETE api/<TecnologiaController>/5
        [HttpDelete("Delete/{ID}")]
        public void Delete(int id)
        {
            var obj = _AppserviceTecnologia.GetById(id);
            _AppserviceTecnologia.Remove(obj);
        }
    }
}
