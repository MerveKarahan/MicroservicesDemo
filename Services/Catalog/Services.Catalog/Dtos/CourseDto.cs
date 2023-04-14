﻿using MongoDB.Bson.Serialization.Attributes;
using Services.Catalog.Models;
using System;

namespace Services.Catalog.Dtos
{
    internal class CourseDto
    {
        
        public string Id { get; set; }

        public string UserId { get; set; } //Id string = güvenli
        public string CourseName { get; set; }

        
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

      
        public DateTime CreatedTime { get; set; }

        public FeatureDto Feature { get; set; } //feature tablosunu bağladım.

        
        public string CategoryId { get; set; }

      
        public CategoryDto Category { get; set; }
    }
}
