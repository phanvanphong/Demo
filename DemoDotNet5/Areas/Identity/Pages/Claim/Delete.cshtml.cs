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
    public class DeleteModel : PageModel
    {
        private readonly EShopDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DeleteModel(RoleManager<IdentityRole> roleManager, EShopDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        // Tạo lớp Input Model chứa thuộc tính Name (Roll Name)
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
        public IdentityRole Role { get; set; }
        public IdentityRoleClaim<string> Claim { get; set; }



        public async Task<IActionResult> OnGet(int claimId)
        {
            // Lấy lại danh sách các claim của role theo claimId
            Claim = _context.RoleClaims.Where(c => c.Id == claimId).FirstOrDefault();

            // Lấy lại thông tin của Role
            Role = await _roleManager.FindByIdAsync(Claim.RoleId);
            if (Role == null) return NotFound();

            // Thực hiện xóa claim của role
            await _roleManager.RemoveClaimAsync(Role, new Claim(Claim.ClaimType, Claim.ClaimValue));

            // Quay trở lại trang Edit Role vs roleId
            return RedirectToPage("../Role/Edit", new { roleId = Role.Id });
        }
    }
}
