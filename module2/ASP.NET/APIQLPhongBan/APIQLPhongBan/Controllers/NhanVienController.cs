using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Domain.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIQLPhongBan.Controllers
{
    
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        INhanVienService _NhanVienService;
        public NhanVienController(INhanVienService NhanVienService)
        {
            _NhanVienService = NhanVienService;
        }
        [HttpGet]
        [Route("api/nhanvien/gets/{id}")]
        public IList<NhanVien> Gets(int id)
        {
            return _NhanVienService.GetAllNhanVien(id);
        }
        // GET api/values/5
        [HttpGet]
        [Route("api/nhanvien/get/{id}")]
        public NhanVien Get(int id)
        {
            return _NhanVienService.GetNhanVienById(id);
        }
        // POST api/values
        [HttpPost]
        [Route("api/nhanvien/create")]
        public bool Create([FromBody] NhanVien nhanvien)
        {
            return _NhanVienService.AddNhanVien(nhanvien);
        }
        // PUT api/values/5
        [HttpPut]
        [Route("api/nhanvien/update")]
        public bool Update([FromBody] NhanVien nhanVien)
        {
            return _NhanVienService.UpdateNhanVien(nhanVien);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/nhanvien/delete")]
        public bool Delete([FromBody]NhanVienDeleteRequest request)
        {
            return _NhanVienService.DeleteNhanVien(request.Id);
        }
    }
}