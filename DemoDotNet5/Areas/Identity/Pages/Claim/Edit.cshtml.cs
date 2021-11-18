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
    public class EditModel : PageModel
    {
        private readonly EShopDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public EditModel(RoleManager<IdentityRole> roleManager, EShopDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        // Tạo lớp Input Model chứa thuộc tính của Claim
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
        public InputModel Input { set; get; } // giống như ViewModel nhưng sẽ tự động convert kiểu và gán cho thuộc tính của Controller
        public IdentityRole Role { get; set; }
        public IdentityRoleClaim<string> Claim { get; set; }


        public async Task<IActionResult> OnGet(int claimId)
        {
            // Lấy lại danh sách claim của role theo claimId
            Claim = _context.RoleClaims.Where(c => c.Id == claimId).FirstOrDefault();

            // Lấy lại thông tin của Role
            Role = await _roleManager.FindByIdAsync(Claim.RoleId);
            if (Role == null) return NotFound();

            // Gán dữ liệu cho lớp Input Model
            Input = new InputModel()
            {
                ClaimType = Claim.ClaimType,
                ClaimValue = Claim.ClaimValue
            };
            return Page();
        }

        // Tạo mới Claim cho Role
        public async Task<IActionResult> OnPostAsync(int claimId)
        {
            // Lấy lại danh sách Claim của role theo claim Id
            Claim = _context.RoleClaims.Where(c => c.Id == claimId).FirstOrDefault();
            
            // Lấy lại thông tin Role
            Role = await _roleManager.FindByIdAsync(Claim.RoleId);
            if (Role == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //  Gán thuộc tính cho Claim và lưu lại
            Claim.ClaimType = Input.ClaimType;
            Claim.ClaimValue = Input.ClaimValue;
            await _context.SaveChangesAsync();
            
            // Trở về role trang Edit Role

            return RedirectToPage("../Role/Edit", new {roleId = Role.Id });
        }
    }
}
