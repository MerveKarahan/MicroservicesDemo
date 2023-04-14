﻿using Microservices.Shared.Dtos;
using Services.Catalog.Dtos;
using Services.Catalog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Catalog.Services
{
     interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(Category category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}