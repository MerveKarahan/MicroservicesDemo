using AutoMapper;
using Microservices.Shared.Dtos;
using MongoDB.Driver;
using Services.Catalog.Dtos;
using Services.Catalog.Models;
using Services.Catalog.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Catalog.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection; //db'ye bağlama
        private readonly IMapper _mapper; //dönüştürme

        public CategoryService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);//client'a bağlandım

            var database = client.GetDatabase(databaseSettings.DatabaseName);//client üzerinden veri tabanımı aldım

            _categoryCollection = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);

            _mapper = mapper;
        }
        public async Task<Response<List<CategoryDto>>>GetAllAsync()
        {
            var categories = await _categoryCollection.Find(category  => true ).ToListAsync();
            return  Response<List<CategoryDto>>.Success(_mapper.Map<List<CategoryDto>>(categories), 200);
        }
        public async Task<Response<CategoryDto>> CreateAsync(Category category)
        {
            await _categoryCollection.InsertOneAsync(category); //birden fazla olsa insertMany kullanacaktım.Bu işem category'ye ıd sini verip döndürecek.
            return Response<CategoryDto>.Success(_mapper.Map<CategoryDto>(category),200);

        }
        public async Task<Response<CategoryDto>> GetByIdAsync(string id)
        {
            var category = await _categoryCollection.Find<Category>(x => x.Id == id).FirstOrDefaultAsync();
            if (category == null)
            {
                return Response<CategoryDto>.Fail("Category not found", 404);
            }
            return Response<CategoryDto>.Success(_mapper.Map<CategoryDto>(category), 200);
        }
    }
}
