using Lab.Demo.Entities;
using Lab.Demo.Logic;
using Lab.Demo.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic logic = new TerritoriesLogic();

        // GET: Territories
        public ActionResult Index()
        {
            List<Entities.Territories> territories = logic.GetAll();

            List<TerritoriesView> territoriesViews = territories.Select(s => new TerritoriesView
            {
                Id = s.TerritoryID,
                Description = s.TerritoryDescription,
                RegionId = s.RegionID
            }).ToList();

            return View(territoriesViews);
        }

        public ActionResult Insert()
        {
            ViewBag.Message = "Insert";

            return View();
        }
        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            try
            {
                Territories territoriesEntity = new Territories
                {
                    TerritoryID = territoriesView.Id,
                    TerritoryDescription = territoriesView.Description,
                    RegionID = territoriesView.RegionId
                };

                logic.Add(territoriesEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }

        }
        public ActionResult Delete(string id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(string id)
        {
            try
            {
                Territories territoriesUpdate = logic.GetOne(id);
                TerritoriesView territoriesView = new TerritoriesView
                {
                    Id = territoriesUpdate.TerritoryID,
                    Description = territoriesUpdate.TerritoryDescription,
                    RegionId = territoriesUpdate.RegionID
                };

                ViewBag.Message = "Update";
                return View("Insert", territoriesView);

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        [HttpPost]
        public ActionResult Update(TerritoriesView territoriesView)
        {
            try
            {

                Territories territoriesEntity = new Territories
                {
                    TerritoryID = territoriesView.Id,
                    TerritoryDescription = territoriesView.Description,
                    RegionID = territoriesView.RegionId
                };
                logic.Update(territoriesEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}