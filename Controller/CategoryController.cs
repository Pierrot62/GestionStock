using AutoMapper;
using GestionStock.Data;
using GestionStock.Data.Dtos;
using GestionStock.Data.Models;
using GestionStock.Data.Profiles;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Controller
{
    class CategoryController : ControllerBase
    {

        private readonly CategoryServices _service;
        private readonly IMapper _mapper;

        public CategoryController(MyDbContext _context)
        {
            _service = new CategoryServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategoryProfiles>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Category
        [HttpGet]
        public IEnumerable<CategoryDTO> GetAllCategory()
        {
            IEnumerable<Category> listeCategory = _service.GetAllCategory();
            return _mapper.Map<IEnumerable<CategoryDTO>>(listeCategory);
        }

        //GET api/Category/{i}
        [HttpGet("{id}", Name = "GetCategoryById")]
        public ActionResult<CategoryDTO> GetCategoryById(int id)
        {
            Category commandItem = _service.GetCategoryById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CategoryDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/Category
        [HttpPost]
        public ActionResult<CategoryDTO> CreateCategory(CategoryDTOIn objIn)
        {
            Category obj = _mapper.Map<Category>(objIn);
            _service.AddCategory(obj);
            return CreatedAtRoute(nameof(GetCategoryById), new { Id = obj.IdCategories }, obj);
        }

        //POST api/Category/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, CategoryDTOIn obj)
        {
            Category objFromRepo = _service.GetCategoryById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategory(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Category/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCategoryUpdate(int id, JsonPatchDocument<Category> patchDoc)
        {
            Category objFromRepo = _service.GetCategoryById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Category objToPatch = _mapper.Map<Category>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateCategory(objFromRepo);
            return NoContent();
        }

        //DELETE api/Category/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            Category obj = _service.GetCategoryById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategory(obj);
            return NoContent();
        }


    }
}
