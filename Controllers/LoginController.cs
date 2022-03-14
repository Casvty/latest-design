using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using test_design.Models;

namespace test_design.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginViewModel loginViewModel)
        {
            LoginDetails loginDetails = new LoginDetails();
            loginDetails.Username= loginViewModel.Username;
            loginDetails.Password = loginViewModel.Password;
            loginDetails.AccessLevel = 2;

           
            LoginDetails receivedResponse = new LoginDetails();
            receivedResponse.UserId = 1; // GLÖM INTE ATT TA BORT NÄR API FINNS 
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(loginDetails), Encoding.UTF8, "application/json");

                // Lägg in rätt api och ta bort kommentarerna 
                //using (var response = await httpClient.PostAsync("https://localhost:44324/api/Reservation", content))
                //{
                //    string apiResponse = await response.Content.ReadAsStringAsync();
                //    receivedResponse = JsonConvert.DeserializeObject<LoginDetails>(apiResponse);
                //}
            }

            // cookies authenticate, kolla kod från höstas
            if (receivedResponse.UserId != 0)
            {
                //godkänd inloggning
                return RedirectToAction("Index", "Home"); // Ändra till rätt väg 
            }
            else
            {
                return View();
            }

            // Lägg till en loggaut-knapp "sign out för authentication"
            // Lägg till authorize
        }
    }
}
