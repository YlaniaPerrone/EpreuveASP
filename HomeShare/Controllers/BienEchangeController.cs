// using HoliDayRental.Common.Repository;
// using HoliDayRental.Handlers;
// using HoliDayRental.Models.BienEchange;
// //using HoliDayRental.Models.Payss;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace HoliDayRental.Controllers
// {
//     public class BienEchangeController : Controller
//     {
//         private readonly IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange> _bienService;
//         private readonly IPaysRepository<HoliDayRental.BLL.Entity.Pays> _paysService;
//         private readonly IMembreRepository<HoliDayRental.BLL.Entity.Membre> _membreService;
//         
//
//
//         // GET: BienEchange
//         public BienEchangeController(IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange> bienEchangeService, IPaysRepository<HoliDayRental.BLL.Entity.Pays> paysService, IMembreRepository<HoliDayRental.BLL.Entity.Membre> membreService) 
//         { 
//             _bienService = bienEchangeService;
//             _paysService = paysService;
//             _membreService = membreService;
//         }
//         public ActionResult Index()
//         {
//             IEnumerable<BienEchangeItem> model = _bienService.Get().Select(b => b.ToListItem());
//             model = model.Select(m => { m.Pays = _paysService.Get((int)m.idPays).ToListPays(); return m; });
//             return View(model);
//         }
//             
//         // GET: BienEchange/Details/5
//         public ActionResult Details(int id)
//         {
//             
//             BienDetails model = _bienService.Get(id).ToDetails();
//            return View(model);
//         }
//
//         // GET: BienEchange/Create
//         public ActionResult Create()
//         {
//             BienEchangeCreate bien = new BienEchangeCreate();
//             bien.PaysList = _paysService.Get().Select(b => b.ToListPays());
//             bien.listMembre = _membreService.Get().Select(b => b.ToListMembre());
//             bien.DateCreation = DateTime.Now;
//             bien.isEnabled = true;
//             return View(bien);
//         }
//
//         // POST: BienEchange/Create
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public ActionResult Create(BienEchangeCreate collection)
//         {
//             try
//             {
//                 
//                 if (!ModelState.IsValid) throw new Exception("ops a error !!");
//                 HoliDayRental.BLL.Entity.BienEchange result = new BLL.Entity.BienEchange(
//                 0,
//                 collection.titre,
//                 collection.DescCourte,
//                 collection.DescLong,
//                 collection.NombrePerson,
//                 collection.idPays,
//                 collection.Ville,
//                 collection.Rue,
//                 collection.Numero,
//                 collection.CodePostal,
//                 collection.Photo,
//                 collection.AssuranceObligatoire,
//                 true,
//                 collection.DisabledDate,
//                 collection.Latitude,
//                 collection.Longitude,
//                 collection.idMembre,
//                 DateTime.Now
//                ) ;
//                 {
//                 };
//                 this._bienService.Insert(result);
//                 return RedirectToAction(nameof(Index));
//             }
//             catch (Exception e)
//             {
//                 ViewBag.Error = e.Message;
//                 collection.PaysList = _paysService.Get().Select(b => b.ToListPays());
//                 collection.listMembre = _membreService.Get().Select(b => b.ToListMembre());
//                 collection.DateCreation = DateTime.Now;
//                 return View(collection);
//             }
//         }
//
//         // GET: BienEchange/Edit/5
//         public ActionResult Edit(int id)
//         {
//             BienEdit model = this._bienService.Get(id).ToBienEdit();
//             model.PaysList = _paysService.Get().Select(b => b.ToListPays());
//             return View(model);
//         }
//         
//         // POST: BienEchange/Edit/5
//         // [HttpPost]
//         // [ValidateAntiForgeryToken]
//         // public ActionResult Edit(int id, BienEdit collection)
//         // {
//             // HoliDayRental.BLL.Entity.BienEchange result = this._bienService.Get(id);
//             // try
//             // {
//             //     if (result is null) throw new Exception("Pas de résultat avec cet identifiant");
//             //     if (!(ModelState.IsValid)) throw new Exception();
//             //     result.idBien = collection.idBien;
//             //     result.titre = collection.titre;
//             //     result.DescCourte = collection.DescCourte;
//             //     result.DescLong = collection.DescLong;
//             //     result.NombrePerson = collection.NombrePerson;
//             //     result.idPays = collection.Pays;
//             //     result.Ville = collection.Ville;
//             //     result.Rue = collection.Rue;
//             //     result.Numero = collection.Numero;
//             //     result.CodePostal = collection.CodePostal;
//             //     result.Photo = collection.Photo;
//             //     result.AssuranceObligatoire = collection.AssuranceObligatoire;
//             //     result.isEnabled = collection.isEnabled;
//             //     result.DisabledDate = collection.DisabledDate;
//             //     result.Latitude = collection.Latitude;
//             //     result.Longitude = collection.Longitude;
//             //
//             //     
//             //     return RedirectToAction(nameof(Index));
//             // }
//             // catch (Exception e)
//             // {
//             //     ViewBag.Errors = e.Message;
//             //     if (result is null) return RedirectToAction(nameof(Index));
//             //     return View(result.ToBienEdit());
//             // }
//         // }
//
//         // GET: BienEchange/Delete/5
//         // public ActionResult Delete(int id)
//         // {
//         //     return View();
//         // }
//         //
//         // // POST: BienEchange/Delete/5
//         // [HttpPost]
//         // [ValidateAntiForgeryToken]
//         // public ActionResult Delete(int id, IFormCollection collection)
//         // {
//         //     try
//         //     {
//         //         return RedirectToAction(nameof(Index));
//         //     }
//         //     catch
//         //     {
//         //         return View();
//         //     }
//         // }
//     }
// }
