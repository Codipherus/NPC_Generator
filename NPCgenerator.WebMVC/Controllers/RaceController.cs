using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NPCgenerator.Data;
using NPCgenerator.Models.Create;
using NPCgenerator.Models.Edit;
using NPCgenerator.Services;

namespace NPCgenerator.WebMVC.Controllers
{
    public class RaceController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RaceService(userId);
            var model = service.GetRaces();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RaceCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateRaceService();

            if (service.CreateRace(model))
            {
                TempData["SaveResult"] = "Your race was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Race could not be created.");

            return View(model);
        }

        private RaceService CreateRaceService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RaceService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateRaceService();
            var model = svc.GetRaceById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateRaceService();
            var detail = service.GetRaceById(id);
            var model =
                new RaceEdit
                {
                    RaceId = detail.RaceId,
                    RaceName = detail.RaceName,
                    
                };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RaceEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.RaceId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateRaceService();

            if (service.UpdateRace(model))
            {
                TempData["SaveResult"] = "Your note was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your note could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateRaceService();
            var model = svc.GetRaceById(id);
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateRaceService();
            service.DeleteRace(id);
            TempData["SaveResult"] = "Your note was deleted";
            return RedirectToAction("Index");
        }
    }
}
