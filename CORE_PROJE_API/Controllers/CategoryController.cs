using CORE_PROJE_API.DAL.ApiContext;
using CORE_PROJE_API.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var listed = _context.Categories.ToList();
            return Ok(listed);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _context.Categories.Find(id);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
           
         [HttpPost]
         public IActionResult AddCategory(Category p)
        {
             _context.Categories.Add(p);
            _context.SaveChanges();
            return Created("",p);
        }

        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
           var value= _context.Categories.Find(id);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(value);
                _context.SaveChanges();
                return NoContent();
            }
        }
         
        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
           var value= _context.Categories.Find(p.CategoryId);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                _context.Update(value);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
