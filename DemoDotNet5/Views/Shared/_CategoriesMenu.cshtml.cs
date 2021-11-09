using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OA.Service;

namespace DemoDotNet5.Views.Shared
{
    public class _CategoriesMenuModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public _CategoriesMenuModel(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public List<CategoryViewModel> categoryViewModel { set; get; }

        public IActionResult OnGet()
        {
            var categories = _categoryService.GetList();
            categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            return Page();
        }
    }
}
