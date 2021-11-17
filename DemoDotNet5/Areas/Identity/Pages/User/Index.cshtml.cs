using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OA.Data;

namespace DemoDotNet5.Areas.Identity.Pages.User
{
    [Authorize(Policy = "Administrator")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _useManager;
        public IndexModel(UserManager<ApplicationUser> userManager)
        {
            _useManager = userManager;
        }

        // Tạo lớp UserAndRole kế thừa từ lớp ApplicationUser (có tất cả các thuộc tính của ApplicationUser)
        // và bổ sung thêm thuộc tính là RollNames để lấy tên các role của từng User hiển thị ra danh sách
        public class UserAndRole : ApplicationUser
        {
            public string RollNames { get; set; }
        }

        // Tạo thuộc tính Users có kiểu là danh sách UserAndRole
        public List<UserAndRole> Users { set; get; }


        public async Task<IActionResult> OnGet()
        {
            // Lấy danh sách User, gán giá trị từng thuộc tính trong class UserAndRole và sắp xếp thep Username
            var query =  _useManager.Users.Select(u => new UserAndRole() { 
                            Id = u.Id,
                            UserName = u.UserName
                     }).OrderBy(u => u.UserName);
            
            // Thực hiện câu truy vấn => trả về danh sách User
            Users =  query.ToList();

            // Thực hiện vòng lặp 
            foreach(var user in Users)
            {   
                // Lấy lại danh sách các role tương ứng với user
                var roles = await _useManager.GetRolesAsync(user);
                // Gán vào thuộc tính RollNames và nối với nhau bằng dấu ,
                user.RollNames = string.Join(",", roles);
            }
            return Page();
        }
        
      
    }
}
