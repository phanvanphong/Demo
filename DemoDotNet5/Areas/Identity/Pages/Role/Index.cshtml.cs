using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoDotNet5.Areas.Identity.Pages.Role
{
    [Authorize(Policy = "Administrator")]
    public class IndexModel : PageModel 
    {   
        private readonly RoleManager<IdentityRole> _roleManager;
        public IndexModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
    
        // Tạo lớp RoleModel kế thừa IdentityRole bổ sung thuộc tính là mảng Claims
        // nhằm hiển thị thêm các Claims của Role
        public class RoleModel : IdentityRole
        {
            public string[] Claims { get; set; }
        }

        // Tạo ra thuộc tính roles có kiểu là danh sách các RoleModel
        public List<RoleModel> roles { set; get; }

        // Phương thức bất đồng bộ OnGet thực hiện lấy tên của các Roles và sắp xếp theo tên
        public async Task<IActionResult> OnGet()
        {
            // Lấy ra danh sách role trong IdentityRole
            var rolesData = await _roleManager.Roles.OrderByDescending(r=>r.Name).ToListAsync();
            // Khởi tạo danh sách roleModel
            roles = new List<RoleModel>();
            foreach(var item in rolesData)
            {
                // Lấy claim của từng role
                var claims = await _roleManager.GetClaimsAsync(item);
                // Trả về mảng gồm các chuỗi tên claim và giá trị của claim
                var claimsString = claims.Select(c => c.Type + "=" + c.Value);
                // Gán từng thuộc tính cho RoleModel
                var roleModel = new RoleModel()
                {
                    Name = item.Name,
                    Id = item.Id,
                    Claims = claimsString.ToArray()
                };
                // Thêm vào danh sách roles
                roles.Add(roleModel);
            }
            return Page();
        }
        
    }
}
