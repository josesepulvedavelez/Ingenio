using Ingenio.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ingenio.WebClient.Controllers
{
    public class UsuarioController : Controller
    {
        string baseUrl = ConfigurationManager.AppSettings["URI"];

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Usuario usuario)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                var postTask = client.PostAsJsonAsync<Usuario>("Api/Usuario", usuario);
                
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Clima");
                }
            }

            return View(usuario);
        }

    }
}