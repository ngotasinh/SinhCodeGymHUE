using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPcorePhongBan.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using ASPcorePhongBan.Models.NhanVien;

namespace ASPcorePhongBan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var phongBans = new List<PhongBanView>();
            var url = "https://localhost:44372/api/phongban/gets";
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

                phongBans = JsonConvert.DeserializeObject<List<PhongBanView>>(responseData);
            }
            return View(phongBans);
        }
        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult Create(PhongBanCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/phongban/create");
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
            return View(new PhongBanCreate());
        }
        public IActionResult Details(int id)
        {
            var phongBan = new PhongBanView();
            var url = "https://localhost:44372/api/phongban/get/" + id;
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

                phongBan = JsonConvert.DeserializeObject<PhongBanView>(responseData);
            }
            return View(phongBan);
        }
        public IActionResult Edit(int id)
        {
            var phongBan = new PhongBanEdit();
            var url = "https://localhost:44372/api/phongban/get/" + id;
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

                phongBan = JsonConvert.DeserializeObject<PhongBanEdit>(responseData);
            }
            return View(phongBan);
        }
        [HttpPost]
        public IActionResult Edit(PhongBanEdit model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/phongban/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Success"] = "User has been update successfully";
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Delete(int id)
        {
            var model = new PhongBanDelete()
            {
                ID = id
            };
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/phongban/delete");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult NhanVien(int id)
        {

            var nhanViens = new List<NhanVienView>();
            var url = "https://localhost:44372/api/nhanvien/gets/" + id;
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

                nhanViens = JsonConvert.DeserializeObject<List<NhanVienView>>(responseData);
            }
            return View(nhanViens);
        }

        public IActionResult CreateNV()
        {
            ViewBag.PhongBans = GetPhongBan();
            return View();
        }

        [HttpPost]
        public IActionResult CreateNV(NhanVienCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/nhanvien/create");
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
            ViewBag.PhongBans = GetPhongBan();
            ModelState.Clear();
            return View(new NhanVienCreate());
        }

        private List<PhongBanEdit> GetPhongBan()
        {
            var phongBans = new List<PhongBanEdit>();
            var url = "https://localhost:44372/api/phongban/gets";
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

                phongBans = JsonConvert.DeserializeObject<List<PhongBanEdit>>(responseData);
            }
            return phongBans;
        }

        public IActionResult DetailsNV(int id)
        {
            var nhanVien = new NhanVienView();
            var url = "https://localhost:44372/api/nhanvien/get/" + id;
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

                nhanVien = JsonConvert.DeserializeObject<NhanVienView>(responseData);
            }
           
            return View(nhanVien);
        }

        public IActionResult EditNV(int id)
        {
            var nhanVien = new NhanVienEdit();
            var url = "https://localhost:44372/api/nhanvien/get/" + id;
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

                nhanVien = JsonConvert.DeserializeObject<NhanVienEdit>(responseData);
            }
            ViewBag.PhongBans = GetPhongBan();
            return View(nhanVien);
        }
        [HttpPost]
        public IActionResult EditNV(NhanVienEdit model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/nhanvien/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Success"] = "User has been update successfully";
            }
            ViewBag.PhongBans = GetPhongBan();
            return RedirectToAction("NhanVien", "Home");
        }
        public IActionResult DeleteNV(int id)
        {
            var model = new PhongBanDelete()
            {
                ID = id
            };
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44372/api/nhanvien/delete");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("NhanVien", "Home");
        }
    }
}
