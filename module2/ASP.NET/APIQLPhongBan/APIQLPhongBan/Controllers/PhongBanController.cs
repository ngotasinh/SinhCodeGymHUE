using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Domain.Request;
using Microsoft.AspNetCore.Mvc;

namespace APIQLPhongBan.Controllers
{
    
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        IPhongBanService _PhongBanService;
        public PhongBanController(IPhongBanService PhongBanService)
        {
            _PhongBanService = PhongBanService;
        }
        // GET api/values
        [HttpGet]
        [Route("api/phongban/gets")]
        public IList<PhongBanView> Gets()
        {
            return _PhongBanService.GetAllPhongBan();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/phongban/get/{id}")]
        public PhongBanView Get(int id)
        {
            return _PhongBanService.GetPhongBanById(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/phongban/create")]
        public bool Create([FromBody] PhongBan phongBan)
        {
            return _PhongBanService.AddPhongBan(phongBan);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/phongban/update")]
        public bool Update([FromBody] PhongBan phongBan)
        {
            return _PhongBanService.UpdatePhongBan(phongBan);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/phongban/delete")]
        public bool Delete([FromBody]PhongBanDeleteRequest request)
        {
            return _PhongBanService.DeletePhongBan(request.Id);
        }
    }
}
