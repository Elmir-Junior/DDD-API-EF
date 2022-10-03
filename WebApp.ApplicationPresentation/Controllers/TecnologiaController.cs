using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ApplicationPresentation.Service;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Controllers
{
    public class TecnologiaController : Controller
    {

        readonly ServiceApiTecnologia _serviceApi;
        public TecnologiaController(ServiceApiTecnologia serviceApi)
        {
            _serviceApi = serviceApi;
        }

        
        // GET: TecnologiaController
        public ActionResult Index()
        {
            return View(_serviceApi.GetTecnologias());
        }

        // GET: TecnologiaController/Details/5
        public ActionResult Details(int id)
        {
            return View(_serviceApi.getById(id));
        }

        // GET: TecnologiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TecnologiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tecnologia collection)
        {
            try
            {
                _serviceApi.Post(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TecnologiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TecnologiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TecnologiaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TecnologiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _serviceApi.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
