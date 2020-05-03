using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JwtCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JwtCoreWeb.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult _PartialDate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    Login dt = new Login { Username = login.Username, Password = login.Password };

                    string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                    var httpContent = new StringContent(json);
                    httpContent.Headers.Clear();
                    httpContent.Headers.Add("Content-Type", "application/json");
                    var responsetask = client.PostAsync("http://localhost:59444/api/auth/login", httpContent);

                    var result = responsetask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var data = result.Content.ReadAsStringAsync().Result;
                        dynamic token = JObject.Parse(data);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                        return View();
                    }
                }
            }
            else
                return View();
        }
    }
}