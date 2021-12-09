using DemoProject.Data;
using DemoProject.Models;
using DemoProject.Services;
using DemoProject.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        // GET: Service/DashboardService
        DashboardService dashboardService = new DashboardService();

        private readonly ApplicationDbContext context;
        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult ApplicationCreate()
        {
            ViewBag.gender = new List<SelectListItem>(){
                new SelectListItem(){Text="Male", Value="Male"},
                new SelectListItem(){Text="Female", Value="Female"}
            };
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ApplicationCreate(ApplicationModel model)
        {
            if (ModelState.IsValid)
            {

                ApplicationModel applicationModel = new ApplicationModel();
                applicationModel.Name = model.Name;
                applicationModel.Email = model.Email;
                applicationModel.Address = model.Address;
                applicationModel.Gender = model.Gender;
                applicationModel.Contact = model.Contact;
                applicationModel.SSC_Board = model.SSC_Board;
                applicationModel.SSC_Year = model.SSC_Year;
                applicationModel.SSC_Percentage = model.SSC_Percentage;
                applicationModel.HSC_Board = model.HSC_Board;
                applicationModel.HSC_Year = model.HSC_Year;
                applicationModel.HSC_Percentage = model.HSC_Percentage;
                applicationModel.Graduation_Board = model.Graduation_Board;
                applicationModel.Graduation_Year = model.Graduation_Year;
                applicationModel.Graduation_Percentage = model.Graduation_Percentage;

                dashboardService.Saveapplication(context, applicationModel);

                TempData["Success"] = "The application has been uploaded!";

                return View("ApplicationCreate");
            }
            return View(model);
        }

        //Only Admin can access.
        public ActionResult Index(string searchTerm)
        {
            ApplicationListingModel model = new ApplicationListingModel();

            model.SearchTerm = searchTerm;

            model.Applications = dashboardService.Searchapplication(context, searchTerm);

            return View(model);
        }

        public ActionResult ApplicationDetails(int ID)
        {
           var application =  context.Applications.FirstOrDefault(x => x.ID == ID);

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        [HttpGet]
        public ActionResult ApplicationEdit(int? ID)
        {
            ApplicationModel model = new ApplicationModel();

            if (ID.HasValue)
            {
                var application = dashboardService.GetapplicationByID(context, ID.Value);
                model.ID = application.ID;
                model.Name = application.Name;
                model.Email = application.Email;
                model.Contact = application.Contact;
                model.Address = application.Address;
                model.Gender = application.Gender;
                model.SSC_Board = application.SSC_Board;
                model.SSC_Year = application.SSC_Year;
                model.SSC_Percentage = application.SSC_Percentage;
                model.HSC_Board = application.HSC_Board;
                model.HSC_Year = application.HSC_Year;
                model.HSC_Percentage = application.HSC_Percentage;
                model.Graduation_Board = application.Graduation_Board;
                model.Graduation_Year = application.Graduation_Year;
                model.Graduation_Percentage = application.Graduation_Percentage;

                ViewBag.gender = new List<SelectListItem>(){

                new SelectListItem(){Text="Male", Value="Male"},
                new SelectListItem(){Text="Female", Value="Female"}
            };
            }
            return View("ApplicationEdit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ApplicationEdit(ApplicationModel model)
        {
            if (model.ID > 0)
            {
                var application = dashboardService.GetapplicationByID(context, model.ID);

                application.Name = model.Name;
                application.Email = model.Email;
                application.Address = model.Address;
                application.Gender = model.Gender;
                application.Contact = model.Contact;
                application.SSC_Board = model.SSC_Board;
                application.SSC_Year = model.SSC_Year;
                application.SSC_Percentage = model.SSC_Percentage;
                application.HSC_Board = model.HSC_Board;
                application.HSC_Year = model.HSC_Year;
                application.HSC_Percentage = model.HSC_Percentage;
                application.Graduation_Board = model.Graduation_Board;
                application.Graduation_Year = model.Graduation_Year;
                application.Graduation_Percentage = model.Graduation_Percentage;

                dashboardService.Updateapplication(context, application);

                TempData["Success"] = "The application has been updated!";

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult ApplicationDelete(int ID)
        {
            var application = dashboardService.GetapplicationByID(context, ID);

            dashboardService.Deleteapplication(context, application);

            TempData["Success"] = "The Application has been deleted!";

            return RedirectToAction("Index");
        }
    }
}
