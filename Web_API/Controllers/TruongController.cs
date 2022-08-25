using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Truong;
using Web_API.Models;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruongController : ControllerBase
    {
        private ITruongRepository _truong;
        public TruongController(ITruongRepository truongRepository)
        {
            _truong = truongRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Truong> sinhViens = _truong.GetAll();
            var alo = sinhViens.Select(c => new ViewTruong()
            {
                Id = c.Id,
                Ma = c.Ma,
                TenTruong = c.TenTruong                
            });
            return Ok(alo);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            Truong truong = _truong.GetId(id);
            if (truong == null) return NotFound("Không tồn tại sinh viên này");
            ViewTruong alo = new ViewTruong();
            alo.Id = truong.Id;
            alo.Ma = truong.Ma;
            alo.TenTruong = truong.TenTruong;            
            return Ok(alo);
        }
        [HttpPost]
        public IActionResult Add(ViewTruong sv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _truong.Add(sv);
            return CreatedAtAction(nameof(Add), a);
        }
        [HttpPut]
        public IActionResult Update(ViewTruong lop)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _truong.Update(lop);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _truong.Delete(id);
            return Ok();
        }
    }
}
