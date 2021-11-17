using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DemoDotNet5.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoDotNet5.Areas.Identity.Pages.Role
{
    [Authorize(Policy="Administrator")]
    public class EditModel : PageModel
    {
        private readonly EShopDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        public EditModel(RoleManager<IdentityRole> roleManager, EShopDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public class InputModel
        {
            [Display(Name = "Role Name")]
            [Required]
            [StringLength(256,MinimumLength =3)]
            public string Name { get; set; }
        }

        [BindProperty]
        public InputModel Input { set; get; }

        // Khai báo thuộc tính là danh sách Claims
        public List<IdentityRoleClaim<string>> Claims { get; set; }
        public IdentityRole role { get; set; }
        

        public async Task<IActionResult> OnGet(string roleId)
        {
            if (roleId == null) return NotFound();
            role = await _roleManager.FindByIdAsync(roleId);
            if(role != null)
            {
                Input = new InputModel()
                {
                    Name = role.Name
                };
                // Lấy các claims của role có RoleId = Id
                Claims = await _context.RoleClaims.Where(rc => rc.RoleId == role.Id).ToListAsync();
            }
            return Page();

        }
        public async Task<IActionResult> OnPostAsync(string roleId)
        {
            if (roleId == null) return NotFound();
            role = await _roleManager.FindByIdAsync(roleId);

            Claims = await _context.RoleClaims.Where(rc => rc.RoleId == role.Id).ToListAsync();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            role.Name = Input.Name;
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
