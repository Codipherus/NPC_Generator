using Microsoft.AspNet.Identity;
using NPCgenerator.Models;
using NPCgenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPCgenerator.WebMVC.Controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
             var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CharacterService(userId);
             service.CreateCharacter(model);
             return RedirectToAction("Index");
        }
    }
}