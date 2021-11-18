using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OA.Data;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using DemoDotNet5.ViewModel;
using DemoDotNet5.Data;
using OA.Repo;
using OA.Service;

namespace DemoDotNet5.Areas.Identity.Pages.Account
{
    [AllowAnonymous] // Cho phép truy cập mà không cần đăng nhập
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ITokenService _tokenService;

        public LoginModel(SignInManager<ApplicationUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ITokenService tokenService
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _tokenService = tokenService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/Areas/Admin");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/Admin");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    // Lấy thông tin người dùng qua email
                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    // Lấy tất cả các role của user
                    var roles = await _userManager.GetRolesAsync(user);
                    var claims = new List<Claim>
                    {
                        new Claim("Email", Input.Email),
                        // Example xác thực quyền tự thêm
                        // new Claim(ClaimTypes.Role, "ManagerStore"),
                    };

                    // Lặp các quyền lấy được từ user và thêm vào danh sách các claim
                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                    // Tạo token với phương thức CreateToken ở dịch vụ TokenService
                    var token = _tokenService.CreateToken(claims);
                
                    //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
                    //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    //// Thời điểm token hết hạn
                    //var expriry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpriryInDays"]));

                    //var token = new JwtSecurityToken(
                    //    _configuration["JwtIssuer"],
                    //    _configuration["JwtAudience"],
                    //    claims,
                    //    expires: expriry,
                    //    signingCredentials: creds
                    //);


                     _logger.LogInformation("User logged in.");
                    // Trả về trang home và hiển thị token trên url
                    // return RedirectToAction("Index", "Home", token);
                    return LocalRedirect(returnUrl);
                }
                // Nếu thất bại thỳ ném ra thông báo sai tài khoản hoặc mật khẩu
                else
                {
                    ViewData["message"] = "Please check your username or password !";
                }

                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
