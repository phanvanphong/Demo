using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DemoDotNet5.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoDotNet5.Areas.Identity.Pages.Claims
{
    [Authorize(Policy = "Administrator")]
    public class CreateModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public CreateModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // Tạo lớp Input Model chứa thuộc tính cần thiết của Claim
        public class InputModel
        {
            [Display(Name = "Claim Type")]
            [Required]
            [StringLength(256,MinimumLength =3)]
            public string ClaimType { get; set; }

            [Display(Name = "Claim Value")]
            [Required]
            [StringLength(256, MinimumLength = 3)]
            public string ClaimValue { get; set; }
        }
        
        // Tạo thuộc tính Input có kiểu là InputModel để Binding Data từ lớp InputModel
        [BindProperty]
        public InputModel Input { set; get; }

        // Tạo thuộc tính Role
        public IdentityRole Role { get; set; }


        public async Task<IActionResult> OnGet(string roleId)
        {
            // Lấy lại thông tin Role
            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role == null) return NotFound();
            return Page();
        }


        // Thêm claim cho role
        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            // Lấy lại thông tin role
            Role = await _roleManager.FindByIdAsync(roleId);
            if (Role == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Thực hiện thêm mới claim
            var newClaim = new Claim(Input.ClaimType, Input.ClaimValue);
            var result = await _roleManager.AddClaimAsync(Role, newClaim);


            // Trả về trang Edit Role và gán giá trị cho roleId
            return RedirectToPage("../Role/Edit", new {roleId = Role.Id });
        }
    }
}
