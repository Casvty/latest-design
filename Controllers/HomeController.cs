using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using test_design.Models;

namespace test_design.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            SponsorEventViewModel sponsorEvent = new SponsorEventViewModel(); 
            List<Event> eventList = new List<Event>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://193.10.202.74/EventAPI1/api/Events"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    eventList = JsonConvert.DeserializeObject<List<Event>>(apiResponse);
                }
            }
            sponsorEvent.Events = eventList; 
            return View(sponsorEvent);

            List<Sponsor> sponsorList = new List<Sponsor>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://193.10.202.76/SponsorsAPI/api/Sponsors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sponsorList = JsonConvert.DeserializeObject<List<Sponsor>>(apiResponse);
                }
            }
            sponsorEvent.Sponsors = sponsorList;
            return View(sponsorEvent);
        }

        // other methods

        //public ViewResult AddReservation() => View();

        //[HttpPost]
        //public async Task<IActionResult> AddReservation(Reservation reservation)
        //{
        //    Reservation receivedReservation = new Reservation();
        //    using (var httpClient = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), Encoding.UTF8, "application/json");

        //        using (var response = await httpClient.PostAsync("https://localhost:44324/api/Reservation", content))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
        //        }
        //    }
        //    return View(receivedReservation);
        //}



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Event()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
