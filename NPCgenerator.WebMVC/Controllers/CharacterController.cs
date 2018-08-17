using NPCgenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPCgenerator.WebMVC.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            var service = new CharacterService();
            return View(service.CreateCharacter());
        }
    }
}