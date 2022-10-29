using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;



namespace AirlinesProject.Controllers
{
    public class UserController : Controller
    {
        private readonly WebsiteAirlineContext _db;
        
        public UserController(WebsiteAirlineContext db)  //constructor
        {
            _db = db;
        }

        
        public IActionResult Index()
        {
            
            if (ViewBag.MyName != null)
            {
                return View(_db.FlightBookings.ToList());
            }
            else
            {
                return RedirectToAction("details", "User");
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FlightBooking fb)
        {
            _db.FlightBookings.Add(fb);//to add a record to the context
            _db.SaveChanges();//to add a record to the database permanently
            return RedirectToAction("Index");
        }

        public IActionResult Details(int planeid)
        {
            //AirplaneInfo u = _db.AirplaneInfos.Find(planeid);
            return View(_db.AirplaneInfos.ToList());
        }

        
       

         
        public IActionResult Delete(int id)
        
        {
            //TicketReservation t = _db.TicketReservations.Find(id);
            return View();
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            TicketReservation t = _db.TicketReservations.Find(id);
            _db.TicketReservations.Remove(t);
            _db.SaveChanges();
            return RedirectToAction("Details");

        }

        public IActionResult Payment()
        {
            return View();
            return RedirectToAction("Index", "Home");
        }
    }
}


