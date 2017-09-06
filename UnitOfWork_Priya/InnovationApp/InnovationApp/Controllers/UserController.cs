using InnovationApp.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InnovationApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public async Task<ActionResult> GetUsers()
        {
            List<User> _user = new List<User>();

            //call to api
            string uri = ConfigurationManager.AppSettings["ApiUrl"].ToString();
            string api = uri + "api/userapi/getusers";
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await httpClient.GetAsync(api);
                var res = (await response.Content.ReadAsStringAsync());
                _user = JsonConvert.DeserializeObject<List<User>>(res);
                return View(_user);
            }
        }
    }
}