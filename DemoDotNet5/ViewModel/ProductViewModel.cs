﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public IFormFile FileUpload { get; set; }
        public IFormFile FileEdit { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

    }
}
