using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using Project.Models.Domain;
using System.Diagnostics;




namespace Project.Controllers
{
    public class HomeController : Controller
    {

        private readonly MVCDemodbcontext mvcDemodbcontext;
        public HomeController(MVCDemodbcontext mvcDemodbcontext)
        {
            this.mvcDemodbcontext = mvcDemodbcontext;
        }
     

        [HttpGet]
        public IActionResult Index1()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Index1(Addcontact AddcontactRequest)
        {
            var Contact = new contact()
            { 
                ID = Guid.NewGuid(),
                FirstName = AddcontactRequest.FirstName,
                LastName = AddcontactRequest.LastName,
                Telephone = AddcontactRequest.Telephone,
                Email = AddcontactRequest.Email
            };

            mvcDemodbcontext.Add(Contact);
            await mvcDemodbcontext.SaveChangesAsync();
            return RedirectToAction("Index1");



        }
    }
}


    