using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Nghanh;
using Web_API.Models;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NghanhController : Controller
    {
        private readonly INghanhRepository _sinhVienService;

        public NghanhController(INghanhRepository sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Nghanh> sinhViens = _sinhVienService.GetAll();
            var alo = sinhViens.Select(c => new ViewNghanh()
            {
                Id = c.Id,
                Ma=c.Ma,
                TenNghanh=c.TenNghanh
            });
            return Ok(alo);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            Nghanh sinhVien = _sinhVienService.GetId(id);
            if (sinhVien == null) return NotFound("Không tồn tại sinh viên này");
            ViewNghanh alo = new ViewNghanh();
            alo.Id = sinhVien.Id;
            alo.Ma = sinhVien.Ma;
            alo.TenNghanh = sinhVien.TenNghanh;               
            return Ok(alo);
        }
        [HttpPost]
        public IActionResult Add(ViewNghanh sv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _sinhVienService.Add(sv);
            return CreatedAtAction(nameof(Add), a);
        }
        [HttpPut]
        public IActionResult Update(ViewNghanh sinhVien)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _sinhVienService.Update(sinhVien);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _sinhVienService.Delete(id);
            return Ok();
        }
    }
}
