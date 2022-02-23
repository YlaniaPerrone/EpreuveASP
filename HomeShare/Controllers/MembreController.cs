using System;
using HoliDayRental.Common.Repository;
using HoliDayRental.Models.Membre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoliDayRental.Controllers 
{

    public class MembreController : Controller
    {
        private readonly IMembreRepository<HoliDayRental.BLL.Entity.Membre> _membreService;

        public MembreController(IMembreRepository<HoliDayRental.BLL.Entity.Membre> membreService)
        { 
            _membreService = membreService;
        }
        // GET: MembreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MembreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MembreController/Create
        public ActionResult Create()
        {
            MembreCreate membre = new MembreCreate();
            
            return View(membre);
        }

        // POST: MembreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MembreCreate collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                 HoliDayRental.BLL.Entity.Membre result = new BLL.Entity.Membre(
                    0,
                    collection.Nom,
                    collection.Prenom,
                    collection.Email,
                    collection.Pays,
                    collection.Telephone,
                    collection.Login,
                    collection.Password

                ){ };
                this._membreService.Insert(result);
                return RedirectToAction(nameof(Index));
            }
                catch (Exception e)
                {
                    ViewBag.Error = e.Message;
                    return View(collection);
        }
}

// GET: MembreController/Edit/5
public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MembreController/Edit/5
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

        // GET: MembreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MembreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
