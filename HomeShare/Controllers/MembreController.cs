using System;
using System.Collections.Generic;
using System.Linq;
using HoliDayRental.Common.Repository;
using HoliDayRental.Handlers;
using HoliDayRental.Models.Membre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoliDayRental.Controllers
{
    public class MembreController : Controller
    {
        private readonly IMembreRepository<HoliDayRental.BLL.Entity.Membre> _membreService;
        private readonly IPaysRepository<HoliDayRental.BLL.Entity.Pays> _paysService;


        public MembreController(IMembreRepository<HoliDayRental.BLL.Entity.Membre> membreService, IPaysRepository<HoliDayRental.BLL.Entity.Pays> paysService)
        {
            _membreService = membreService;
            _paysService = paysService;
        }

        // GET: MembreController
        public ActionResult Index()
        {
            IEnumerable<MembreItem> model = _membreService.Get().Select(b => b.ToListMembre());

            model = model.Select(m => { m.PaysList = _paysService.Get((int)m.idPays).ToListPays(); return m; });
            return View(model);
        }

        // GET: MembreController/Details/5
        public ActionResult Details(int id)
        {
            MembreDetails model = _membreService.Get(id).ToDtailsMembre();
            return View(model);
        }

        // GET: MembreController/Create
        public ActionResult Create()
        {
            MembreCreate membre = new MembreCreate();
            membre.PaysList = _paysService.Get().Select(b => b.ToListPays());
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

                HoliDayRental.BLL.Entity.Membre result = new HoliDayRental.BLL.Entity.Membre()
                {

                    Nom = collection.Nom,
                    Prenom = collection.Prenom,
                    Email = collection.Email,
                    idPays = collection.idPays,
                    Telephone = collection.Telephone,
                    Login = collection.Login,
                    Password = collection.Password
                };

                this._membreService.Insert(result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                collection.PaysList = _paysService.Get().Select(b => b.ToListPays());
                return View(collection);
            }
        }


        // GET: MembreController/Edit/5
        public ActionResult Edit(int id)
        {
            MembreEdit model = _membreService.Get(id).ToEditMembre();
            model.PaysList = _paysService.Get().Select(b => b.ToListPays());
            return View(model);
        }

        // POST: MembreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MembreEdit collection)
        {
            HoliDayRental.BLL.Entity.Membre result = this._membreService.Get(id);

            try
            {
                if (result is null) throw new Exception("Pas de résultat avec cet identifiant");
                if (!(ModelState.IsValid)) throw new Exception();

                result.idMembre = collection.idMembre;
                result.Nom = collection.Nom;
                result.Prenom = collection.Prenom;
                result.Telephone = collection.Telephone;
                result.Login = collection.Login;
                result.Password = collection.Telephone;
                result.idPays = collection.Pays;
                

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Errors = e.Message;
                if (result is null) return RedirectToAction(nameof(Index));
                return View(result.ToEditMembre());
            }
        }

        // GET: MembreController/Delete/5
        // public ActionResult Delete(int id)
        // {
        //     return View();
        // }
        //
        // // POST: MembreController/Delete/5
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Delete(int id, IFormCollection collection)
        // {
        //     try
        //     {
        //         return RedirectToAction(nameof(Index));
        //     }
        //     catch
        //     {
        //         return View();
        //     }
        // }
    }
}