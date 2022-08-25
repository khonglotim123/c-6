using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;
using Web_API.Models;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienService _sinhVienService;

        public SinhVienController(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<SinhVien> sinhViens = _sinhVienService.GetAll();
            var alo = sinhViens.Select(c => new ViewSinhVien()
            {
                Id=c.Id,
                MaSV = c.MaSV,
                Ten = c.Ho + " " + c.TenDem + " " + c.Ten,
                NgaySinh = c.NgaySinh,
                Email = c.Email,
                PassWord = c.PassWord,
                IdLop = c.IdLop,
                IdNghanh = c.IdNghanh
            });
            return Ok(alo);
        }
        
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            SinhVien sinhVien = _sinhVienService.GetId(id);
            if (sinhVien == null) return NotFound("Không tồn tại sinh viên này");
            ViewSinhVienRequest alo = new ViewSinhVienRequest();
            alo.Id = sinhVien.Id;
            alo.MaSV = sinhVien.MaSV;
            alo.Ho = sinhVien.Ho;
            alo.TenDem = sinhVien.TenDem;
            alo.Ten = sinhVien.Ten;
            alo.NgaySinh = sinhVien.NgaySinh;
            alo.Email = sinhVien.Email;
            alo.IdLop = sinhVien.IdLop;
            alo.IdNghanh = sinhVien.IdNghanh;
            alo.PassWord = sinhVien.PassWord;
            return Ok(alo);
        }
        [HttpPost]
        public IActionResult Add(ViewSinhVienRequest sv)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _sinhVienService.Add(sv);
            return CreatedAtAction(nameof(Add), a);
        }
        [HttpPut]
        public IActionResult Update(ViewSinhVienRequest sinhVien)
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
