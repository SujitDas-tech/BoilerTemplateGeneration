using Microsoft.AspNetCore.Mvc;
using BoilerTemplateGeneration.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using LibGit2Sharp;
using System.IO.Compression;
using System.Net;

namespace BoilerTemplateGeneration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly boilerTemplateDBContext _context;
        public HomeController(boilerTemplateDBContext context,IConfiguration config)
        {
            this._context = context;
            this._config = config;
        
        }
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.TblBackEnd = _context.TblBackEnds.ToList();
            model.TblFronts = _context.TblFronts.ToList();
            return View("HomeIndex",model);
        }

        [HttpPost]
        public IActionResult Index(HomeModel model)
        {
            try
            {
                string id = model.FrontId.ToString() + "-" + model.BackId.ToString();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(_config["AppSettings:WebAPIPath"]);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("mutipart/form-data"));
                client.Timeout = Timeout.InfiniteTimeSpan;
                var content = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>(_config["AppSettings:Param"], Convert.ToString(id)), });
                var resultapi = client.PostAsync(_config["AppSettings:MethodName"], content).Result;
                var path = string.Empty;
                if (resultapi.IsSuccessStatusCode)
                {
                    var outputData = resultapi.Content.ReadAsStringAsync().Result;
                    var jsonPath = outputData.ToString().Trim().Replace("JSON path:", "");
                    path = jsonPath;
                }
                if (!path.Equals(""))
                {
                    
                    TempData["success"] = "File Ready to Download";
                    HomeModel m = new HomeModel();
                    m.FilePath = path;
                    return View("DownloadPage", m);

                }
                
                
            }
            catch(Exception ex)
            {
                TempData["error"] = "Error Occured";
                return RedirectToAction("Index","Home");
            }
            
            return RedirectToAction("Index","Home");
        }
        
        

    
        
    }
}
