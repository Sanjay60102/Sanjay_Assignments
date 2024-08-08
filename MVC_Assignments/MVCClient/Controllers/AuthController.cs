using Microsoft.AspNetCore.Mvc;
using MVCClient.Models;
using Newtonsoft.Json;

namespace MVCClient.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)

        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5147/api/User/"); //set endpoint
                                                                                     //convert model data to json
                    var contentData = new StringContent(JsonConvert.SerializeObject(login),
                        System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("Validate", contentData).Result;
                    //de serialize json data into specific model
                    User user = JsonConvert.DeserializeObject<User>
                        (response.Content.ReadAsStringAsync().Result);
                    if (user != null)
                    {
                       
                            return RedirectToAction("Welcome");
                      
                    }
                    else
                    {
                        ViewBag.ErrorMsg = "Invalid User Credentials";
                        return View();
                    }


                }

            }
            else
                return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5147/api/User/");

                var contentData = new StringContent(JsonConvert.SerializeObject(user),
                   System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("Register", contentData).Result;

                if (ModelState.IsValid)
                {
                    return StatusCode(200, user);
                }
                else
                {
                    return StatusCode(500, "Not Registered");
                }
            }
        }
        public IActionResult Details(User user)
        {
            
            return View(user);
        }
    }
}