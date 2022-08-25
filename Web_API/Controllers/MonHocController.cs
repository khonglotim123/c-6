using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.MonHoc;
using Web_API.Models;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private IMonHocRepository _monHoc;
        public MonHocController(IMonHocRepository lopRepository)
        {
            _monHoc = lopRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<MonHoc> sinhViens = _monHoc.GetAll();
            var alo = sinhViens.Select(c => new ViewMonHoc()
            {
                Id = c.Id,
                Ma = c.Ma,
                TenMon = c.TenMon,
                IdNghanh = c.IdNghanh
            });
            return Ok(alo);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            MonHoc lop = _monHoc.GetId(id);
            if (lop == null) return NotFound("Không tồn tại sinh viên này");
            ViewMonHoc alo = new ViewMonHoc();
            alo.Id = lop.Id;
            alo.Ma = lop.Ma;
            alo.TenMon = lop.TenMon;
            alo.IdNghanh = lop.IdNghanh;
            return Ok(alo);
        }
        [HttpPost]
        public IActionResult Add(ViewMonHoc sv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _monHoc.Add(sv);
            return CreatedAtAction(nameof(Add), a);
        }
        [HttpPut]
        public IActionResult Update(ViewMonHoc lop)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _monHoc.Update(lop);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _monHoc.Delete(id);
            return Ok();
        }
    }
}
