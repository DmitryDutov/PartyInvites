using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet] // HttpGet отвеяает зо отображение изначально пустой формы
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost] // HttpPost отвечает за получение данных + принятие решения о том что с ними делать
        public ViewResult RsvpForm(GuestResponce guestResponce)
        {
            Repository.AddResponce(guestResponce);
            return View("Thanks", guestResponce);
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responces.Where(r => r.WillAttend == true));
        }
    }
}
