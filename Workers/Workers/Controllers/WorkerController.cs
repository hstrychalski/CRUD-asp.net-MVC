using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workers.Models;
using Workers.Services;

namespace Workers.Controllers
{
    public class WorkerController : Controller
    {
        private WorkersDbContext dbcontext;
        private WorkerService workerService;

        public WorkerController()
        {
            dbcontext = new WorkersDbContext();
            workerService = new WorkerService(dbcontext);
        }

       

        [HttpGet]
        public ActionResult DisplayWorkers()
        {
            var result = workerService.GetAll();
            return View("DisplayWorkers", result);
        }

        [HttpGet]
        public ActionResult AddWorker()
        {
            return View("AddWorker");
        }

        [HttpPost]
        public ActionResult AddWorker(Worker workerToAdd)
        {
            if (ModelState.IsValid)
            {
                workerService.Add(workerToAdd);
                var result = workerService.GetAll();
                return View("DisplayWorkers", result);
            }
            else return View("AddWorker");  
        }
    
        public ActionResult RemoveWorker(int workerId)
        {
            workerService.Remove(workerId);
            var result = workerService.GetAll();
            return RedirectToAction("DisplayWorkers");

        }

        [HttpGet]
        public ActionResult EditWorker(int workerId)
        {
            var edit = workerService.GetById(workerId);
            return View("EditWorker", edit);
        }

        [HttpPost]
        public ActionResult EditWorker (Worker editedWorker)
        {
            workerService.Update(editedWorker.ID, editedWorker);

            return RedirectToAction("DisplayWorkers");
        }

      
    }
}