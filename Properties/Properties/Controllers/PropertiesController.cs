using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Properties;
using Properties.Models;

namespace Properties.Controllers
{
    public class PropertiesController : Controller
    {
     
        // GET: Properties/Indenx
        public ActionResult Mansion() 
        {       
            var property2 = new PropertiesClass() { Id = 3, SquareAcres = 750, NumOfBathrooms = 25, NumOfBedrooms = 55, NumOfFloors = 8, PropPrice = 5000000, PropType = "Mansion", Location = "Cherbourg", Country = "France" };
            
            return View( property2);
        }

        // GET: Properties/DetachedHouse
        public ActionResult DetachedHouse()
        {
            var property = new PropertiesClass() { Id = 1, SquareAcres = 300, NumOfBathrooms = 4, NumOfBedrooms = 8, NumOfFloors = 3, PropPrice = 75000, PropType = "House", Location = "Kent", Country = "United kingdom" };
            return View(property);
        }

        // GET: Properties/SemiDetachedHouse
        public ActionResult SemiDetachedHouse()
        {
            var property1 = new PropertiesClass() { Id = 2, SquareAcres = 100, NumOfBathrooms = 1, NumOfBedrooms = 2, NumOfFloors = 2, PropPrice = 250000, PropType = "Semi-detached House", Location = "Liverpool", Country = "United kingdom" };
            return View(property1);
        }

        public ActionResult Listings()
        {

            return View();
        }

        public ActionResult NewListings(/*string username, int? password*/)
        {
            //if (username == "Tevin" && password == 123)
            //{
            //    return View();
            //}
            //return View("The user with the username " + username + " " + "and password do not match");
            return View();
        }

        /*[Route("Viewings/opendates/{year}/{month:regex(\\d{4}):range(1-12)}")]*/
        //public ActionResult PropertiesViews(int year, int month)
        //{


        //    return View();
        //}
    }
}