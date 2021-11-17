using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OA.Data;

namespace DemoDotNet5.Areas.Identity.Pages.User
{
    [Authorize(Policy = "Administrator")]
    public class CreateModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _useManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _useManager = userManager;
            _signManager = signInManager;
            _roleManager = roleManager;
        }
        // Thuộc tính lấy danh sách tất cả role 
        public List<string> AllRoles { get; set; }
        // Thuộc tính lấy thông tin dữ liệu user
        public ApplicationUser UserInfo { get; set; }
        // Binding dữ liệu 
        [BindProperty]
        public string[] RoleNames { get; set; }
       

        // Eidt User và Role 
        public async Task<IActionResult> OnGetAsync(string id)
        {
            // Lấy thông tin user
            UserInfo = await _useManager.FindByIdAsync(id);
            // Lấy tất cả role của user và convert thành mảng string
            RoleNames = (await _useManager.GetRolesAsync(UserInfo)).ToArray<string>();
            // Lấy tất cả danh sách tên role 
            AllRoles =  _roleManager.Roles.Select(r => r.Name).ToList();
            return Page();
        }


        // Thêm role cho User
        public async Task<IActionResult> OnPostAsync(string id)
        {
            // Tìm user theo id
            UserInfo = await _useManager.FindByIdAsync(id);
            // Lấy tất cả những role mà user đang có và convert thành 1 mảng
            var oldRoleNames = (await _useManager.GetRolesAsync(UserInfo)).ToArray();
            // Lấy tất cả những role cần phải xóa (tức là có trong oldRoleNames mà không có trong RoleNames) -> người dùng bỏ chọn
            var deleteRoles = oldRoleNames.Where(r => !RoleNames.Contains(r));
            // Lấy tất cả những role cần thêm vào (tức là có trong RoleNames mà không có trong oldRoleNames) -> người dùng kick chọn
            var addRoles = RoleNames.Where(r => !oldRoleNames.Contains(r));
            
            // Thực hiện xóa role 
            var resultDelete = await _useManager.RemoveFromRolesAsync(UserInfo, deleteRoles);
            // Thực hiện thêm role
            var resultAdd = await _useManager.AddToRolesAsync(UserInfo, addRoles);

            // Lấy lại danh sách các role
            AllRoles = _roleManager.Roles.Select(r => r.Name).ToList();

            return RedirectToPage("./Index");
        }
    }
}
