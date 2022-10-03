using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ApplicationPresentation.Models.ViewModels;
using WebApp.ApplicationPresentation.Models.ViewModels.Candidato;
using WebApp.ApplicationPresentation.Service;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ServiceApiCandidato _serviceApiCandidato;
        private readonly ServiceApiTecnologia _serviceApiTecnologia;
        private readonly ServiceApiVaga _serviceApiVaga;

        public CandidatoController(ServiceApiCandidato serviceApiCandidato, ServiceApiTecnologia serviceApiTecnologia, ServiceApiVaga serviceApiVaga)
        {
            _serviceApiCandidato = serviceApiCandidato;
            _serviceApiTecnologia = serviceApiTecnologia;
            _serviceApiVaga = serviceApiVaga;
        }

        // GET: CandidatoController
        public ActionResult Index()
        {
            return View(_serviceApiCandidato.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(_serviceApiCandidato.getById(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(_serviceApiCandidato.CandidatoCreate());
        }

        
        [HttpPost]
        public ActionResult Create(CandidatoCreateViewModel candidato)
        {
            try
            {
                var obj = _serviceApiCandidato.CandidatoCreate(candidato);
                _serviceApiCandidato.Post(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            return View(_serviceApiCandidato.getById(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Candidato candidato)
        {
            try
            {
                _serviceApiCandidato.Put(candidato);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_serviceApiCandidato.getById(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _serviceApiCandidato.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
