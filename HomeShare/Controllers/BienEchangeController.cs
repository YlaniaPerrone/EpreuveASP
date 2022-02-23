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
        private readonly IPaysRepository<HoliDayRental.BLL.Entity.Pays> _paysService;


        // GET: BienEchange
        public BienEchangeController(IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange> bienEchangeService, IPaysRepository<HoliDayRental.BLL.Entity.Pays> paysService)  
        {
            _bienService = bienEchangeService;
            _paysService = paysService;
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
        public ActionResult Create()
        {
            //IEnumerable<ITLang> language = _langService.Get();
            BienEchangeCreate bien = new BienEchangeCreate();

            return View(bien);
        }

        // POST: BienEchange/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BienEchangeCreate collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
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
                collection.DisabledDate,
                collection.DateCreation,
                collection.Latitude,
                collection.Longitude,
                collection.idMembre


                )
                { };
                this._bienService.Insert(result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View(collection);
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
