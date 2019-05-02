using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GameManager.Sql;

namespace GameManager.Mvc.Controllers
{
    public class GameController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var db = GetDatabase();

            var games = db.GetAll();

            return View(games);
            //return Json(games, JsonRequestBehavior.AllowGet);
        }

        private static SqlGameDatabase GetDatabase()
        {
            var connString = ConfigurationManager.ConnectionStrings["database"];
            var db = new SqlGameDatabase(connString.ConnectionString);
            return db;
        }

        public ActionResult Create ()
        {
            return View(new Game());
        }

        [HttpPost]
        public ActionResult Create( Game model )
        {
            var db = GetDatabase();

            var game = db.Add(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit ( int id )
        {
            var db = GetDatabase();
            var game = db.Get(id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }

        [HttpPost]
        public ActionResult Edit ( Game model )
        {
            var db = GetDatabase();

            var game = db.Update(model.Id, model);

            return RedirectToAction("Index");
        }

        public ActionResult Delete ( int id )
        {
            var db = GetDatabase();
            var game = db.Get(id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }

        [HttpPost]
        public ActionResult Delete( Game model )
        {
            var db = GetDatabase();

            db.Delete(model.Id);

            return RedirectToAction("Index");
        }

        public ActionResult Whatever ( string name, decimal price )
        {
            return Redirect("http://www.google.com");
        }
    }
}