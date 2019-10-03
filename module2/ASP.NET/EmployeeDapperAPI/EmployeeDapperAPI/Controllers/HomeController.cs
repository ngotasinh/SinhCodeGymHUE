using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeDapperAPI.Models;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace EmployeeDapperAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employee = new List<Employee>();
            var url = "https://localhost:44351/api/employee/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                employee = JsonConvert.DeserializeObject<List<Employee>>(responseData);
            }
            return View(employee);
        }
        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:63521/api/user/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            return View(new EmployeeCreate() { });
        }
    }
}
