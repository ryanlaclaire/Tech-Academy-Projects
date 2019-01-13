using AcmeInsuranceQuotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeInsuranceQuotes.Controllers
{
    public class HomeController : Controller
    {
        private CustomerQuotesEntities db = new CustomerQuotesEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Quote()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult FreeQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    DateTime carYear, string carMake, string carModel, bool dUI, 
                                    Nullable<int> speedingTickets, string coverageType, Nullable<decimal> quotePrice)
        {
            quotePrice = 50.00m;
            int age = DateTime.Today.Year - dateOfBirth.Year;
            int carAge = carYear.Year;

            if (age < 25 || age > 100)
            {
                quotePrice += 25;
            }
            if (age < 18)
            {
                quotePrice += 100;
            }
            if (carAge < 2000 || carAge > 2015)
            {
                quotePrice += 25;
            }
            if (carMake == "Porsche" || carMake == "porsche")
            {
                quotePrice += 25;
            }
            if (carMake == "Porsche" || carMake == "porsche" && carModel == "911 Carrera" || carModel == "911 carrera")
            {
                quotePrice += 25;
            }
            if (speedingTickets > 0)
            {
                quotePrice += (speedingTickets * 10);
            }
            if (dUI == true)
            {
                quotePrice += (quotePrice * 25 / 100);
            }
            if (coverageType == "Full")
            {
                quotePrice += (quotePrice * 50 / 100);
            }

            Quote quoteCopy = new Quote();

            using (CustomerQuotesEntities db = new CustomerQuotesEntities())
            {
                Quote newQuote = new Quote();
                newQuote.FirstName = firstName;
                newQuote.LastName = lastName;
                newQuote.EmailAddress = emailAddress;
                newQuote.DateOfBirth = dateOfBirth;
                newQuote.CarYear = carYear;
                newQuote.CarMake = carMake;
                newQuote.CarModel = carModel;
                newQuote.DUI = dUI;
                newQuote.SpeedingTickets = speedingTickets;
                newQuote.CoverageType = coverageType;
                newQuote.QuotePrice = quotePrice;

                db.Quotes.Add(newQuote);
                db.SaveChanges();
                quoteCopy = newQuote;
            }
            return View(quoteCopy);

           
        }

        //public ActionResult NewQuote()
        //{
        //    using (CustomerQuotesEntities db = new CustomerQuotesEntities())
        //    {
        //        //var newQuote = db.Quotes.Where(x => x.Id ).ToList();  //Lambda syntax
        //        var newQuote = (from c in db.Quotes where c.Id == last select c).ToList(); //LINQ syntax
        //        var quotes = new List<Quote>();
        //        foreach (var quote in quotes)
        //        {
                   
        //            quote.FirstName = newQuote.FirstName;
        //            quote.LastName = newQuote.LastName;
        //            quote.EmailAddress = newQuote.EmailAddress;
        //            quote.DateOfBirth = newQuote.DateOfBirth;
        //            quote.CarYear = newQuote.CarYear;
        //            quote.CarMake = newQuote.CarModel;
        //            quote.DUI = newQuote.DUI;
        //            quote.SpeedingTickets = newQuote.SpeedingTickets;
        //            quote.CoverageType = newQuote.CoverageType;
        //            quote.QuotePrice = newQuote.QuotePrice;
        //        }

        //        return View(quotes);
        //    }
        //    return View();
        //}
    }
}