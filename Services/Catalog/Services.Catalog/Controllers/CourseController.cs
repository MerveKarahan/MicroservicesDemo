using Microservices.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Catalog.Dtos;
using Services.Catalog.Services;
using System.Threading.Tasks;

namespace Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CourseController : BaseController
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
           _courseService = courseService;
        }
        public async Task<IActionResult> GetAll()
        {
            var responce = await _courseService.GetAllAsync();
            return CreateActionResultInstant(responce);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetAll(string id)
        {
            var responce =await _courseService.GetByIdAsync(id);
            return CreateActionResultInstant(responce);
        }
        [Route("/api/[controller]/GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var responce = await _courseService.GetAllByUserIdAsync(userId);
            return CreateActionResultInstant(responce);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto courseCreateDto)
        {
            var responce = await _courseService.CreateAsync(courseCreateDto);
            return CreateActionResultInstant(responce);
        }
        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto courseUpdateCreateDto)
        {
            var responce = await _courseService.UpdateAsync(courseUpdateCreateDto);
            return CreateActionResultInstant(responce);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var responce = await _courseService.DeleteAsync(id);
            return CreateActionResultInstant(responce);
        }
    }
}
