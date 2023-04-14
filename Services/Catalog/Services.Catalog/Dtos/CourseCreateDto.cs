﻿using System;

namespace Services.Catalog.Dtos
{
    internal class CourseCreateDto
    {
    

        public string UserId { get; set; } 
        public string CourseName { get; set; }

        public string Picture { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }
      
        public FeatureDto Feature { get; set; }


        public string CategoryId { get; set; }
    }
}