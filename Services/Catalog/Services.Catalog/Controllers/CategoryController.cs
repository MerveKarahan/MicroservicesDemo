﻿using Microservices.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Catalog.Dtos;
using Services.Catalog.Services;
using System.Threading.Tasks;

namespace Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        internal CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll()
        {
            var categories= await _categoryService.GetAllAsync();
            return CreateActionResultInstant(categories);
        }
        
      
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var responce = await _categoryService.CreateAsync(categoryDto);
            return CreateActionResultInstant(responce);
        }
        
    }
}
