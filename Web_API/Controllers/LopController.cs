using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Lop;
using Web_API.Models;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopController : ControllerBase
    {
        private ILopRepository _lop;
        public LopController(ILopRepository lopRepository)
        {
            _lop = lopRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Lop> sinhViens = _lop.GetAll();
            var alo = sinhViens.Select(c => new ViewLop()
            {
                Id = c.Id,
                Ma = c.Ma,
                TenLop = c.TenLop,
                IdTruong=c.IdTruong
            });
            return Ok(alo);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            Lop lop = _lop.GetId(id);
            if (lop == null) return NotFound("Không tồn tại sinh viên này");
            ViewLop alo = new ViewLop();
            alo.Id = lop.Id;
            alo.Ma = lop.Ma;
            alo.TenLop = lop.TenLop;
            alo.IdTruong = lop.IdTruong;
            return Ok(alo);
        }
        [HttpPost]
        public IActionResult Add(ViewLop sv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _lop.Add(sv);
            return CreatedAtAction(nameof(Add), a);
        }
        [HttpPut]
        public IActionResult Update(ViewLop lop)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _lop.Update(lop);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _lop.Delete(id);
            return Ok();
        }
    }
}
