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
    public class VagaController : Controller
    {
        readonly ServiceApiVaga _serviceApi;

        public VagaController(ServiceApiVaga serviceApi)
        {
            _serviceApi = serviceApi;
        }

        // GET: VagaController
        public ActionResult Index()
        {
            return View(_serviceApi.GetVagas());
        }

        // GET: VagaController/Details/5
        public ActionResult Details(int id)
        {
            return View(_serviceApi.getById(id));
        }

        // GET: VagaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VagaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vaga vaga)
        {
            try
            {
                _serviceApi.Post(vaga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VagaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_serviceApi.getById(id));
        }

        // POST: VagaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vaga vaga)
        {
            try
            {
                _serviceApi.Put(vaga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VagaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_serviceApi.getById(id));
        }

        // POST: VagaController/Delete/5
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
