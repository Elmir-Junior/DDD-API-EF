using Microsoft.AspNetCore.Mvc;
using System;
using WebApp.Application.DTO.DTO;
using WebApp.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.ApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly IApplicationServiceCandidato _AppserviceCandidato;

        public CandidatoController(IApplicationServiceCandidato appserviceCandidato)
        {
            _AppserviceCandidato = appserviceCandidato;
        }

        // GET: api/<VagasController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AppserviceCandidato.GetAll());
        }

        // GET api/<VagasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_AppserviceCandidato.GetById(id));
        }

        // POST api/<VagasController>
        [HttpPost("Post/")]
        public void Post(CandidatoDTO candidato)
        {
            _AppserviceCandidato.Add(candidato);
        }

        // PUT api/<VagasController>/5
        [HttpPut("Put/")]
        public void Put(int id, [FromBody] CandidatoDTO vagaDTO)
        {
            _AppserviceCandidato.Update(vagaDTO);
        }

        // DELETE api/<VagasController>/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var obj = _AppserviceCandidato.GetById(id);
            _AppserviceCandidato.Remove(obj);
            return RedirectToAction(nameof(Index));

        }
    }
}
