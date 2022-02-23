using HoliDayRental.Common.Repository;
using HoliDayRental.Handlers;
using HoliDayRental.Models.BienEchange;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HoliDayRental.Controllers
{
    public class BienEchangeController : Controller
    {
        private readonly IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange> _bienService;

        // GET: BienEchange
        public BienEchangeController(IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange> bienEchangeService)  
        {
            _bienService = bienEchangeService;
        }
        public ActionResult Index()
        {
            IEnumerable<BienEchangeItem> model = _bienService.Get().Select(b => b.ToListItem());
            return View(model);
        }

        // GET: BienEchange/Details/5
        public ActionResult Details(int id)
        {
            
            BienDetails model = _bienService.Get(id).ToDetails();
            return View(model);
        }

        // GET: BienEchange/Create
        public ActionResult Create(BienEchangeCreate collection)
        {
            BienEchangeCreate bien  = new BienEchangeCreate();
            HoliDayRental.BLL.Entity.BienEchange result = new BLL.Entity.BienEchange(
                0,
                collection.titre,
                collection.DescCourte,
                collection.DescLong,
                collection.NombrePerson,
                collection.Pays,
                collection.Ville,
                collection.Rue,
                collection.Numero,
                collection.CodePostal,
                collection.Photo,
                collection.AssuranceObligatoire,
                collection.isEnabled,
                collection.DateCreation,
                collection.Latitude,
                collection.Longitude,
                collection.idBien
                );
            {
                
                //idBien = collection.idBien,
                //titre = collection.titre,
                //DescCourte = collection.DescCourte,
                //DescLong   = collection.DescLong,
                //NombrePerson = collection.NombrePerson,
                //idPays = collection.Pays,
                //Ville = collection.Ville,
                //Rue = collection.Rue,
                //Numero = collection.Numero,
                //CodePostal = collection.CodePostal,
                //Photo = collection.Photo,
                //AssuranceObligatoire =  collection.AssuranceObligatoire,
                //isEnabled = collection.isEnabled,
                ////DisabledDate = collection.DisabledDate,
                //Latitude = collection.Latitude,
                //Longitude = collection.Longitude,
                //idMembre = collection.idMembre,
                ////DateCreation = collection.DateCreation,

            };
            return View(bien);
        }

        // POST: BienEchange/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                //HoliDayRental.BLL.Entity.BienEchange result = new HoliDayRental.BLL.Entity.BienEchange()
                //{
                //    idBien = collection.idBien,

                //}
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BienEchange/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BienEchange/Edit/5
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

        // GET: BienEchange/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BienEchange/Delete/5
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
