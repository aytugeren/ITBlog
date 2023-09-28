using ITBlog.Admin.Models;
using ITBlog.Business.DTO;
using ITBlog.Business.UserServiceFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ITBlog.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        IConfiguration _configuration;
        IUserService _userService;

        public AuthenticationController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SignIn")]
        public IActionResult SignIn([FromBody] LoginModel parameterModel)
        {
            IActionResult response = Unauthorized("Kullanıcı Bulunamadı!");

            if (parameterModel != null && !string.IsNullOrEmpty(parameterModel.Email) && !string.IsNullOrEmpty(parameterModel.Password))
            {
                if (parameterModel.Email.Contains("@"))
                {
                    var model = _userService.GetUserByEmail(parameterModel.Email);
                    if (model != null && !string.IsNullOrEmpty(model.Email) && _userService.CheckUser(model, _configuration["Authentication:SaltPassword"]))
                    {
                        var issuer = _configuration["Jwt:Issuer"];
                        var audience = _configuration["Jwt:Audience"];
                        var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
                        var signInCredentials = new SigningCredentials(
                            new SymmetricSecurityKey(key),
                            SecurityAlgorithms.HmacSha256Signature);

                        var subject = new ClaimsIdentity(new[]
                        {
                        new Claim(JwtRegisteredClaimNames.Sub, model.Email),
                        new Claim(JwtRegisteredClaimNames.Email, model.Email)
                    });

                        var expires = DateTime.UtcNow.AddMinutes(10);

                        var tokenDescriptior = new SecurityTokenDescriptor
                        {
                            Subject = subject,
                            Expires = expires,
                            Issuer = issuer,
                            Audience = audience,
                            SigningCredentials = signInCredentials
                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var token = tokenHandler.CreateToken(tokenDescriptior);
                        var jwtToken = tokenHandler.WriteToken(token);

                        response = Ok(jwtToken);
                    }
                    else
                    {
                        response = Redirect("SignUp");
                    }
                }
            }

            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SignUp")]
        public IActionResult SignUp([FromBody] UserModel parameterModel)
        {
            IActionResult response = BadRequest("Kullanıcı Kayıt İşleminde Sorun Oluştu!");

            if (parameterModel != null && !string.IsNullOrEmpty(parameterModel.Email) && !string.IsNullOrEmpty(parameterModel.Password))
            {
                if (parameterModel.Email.Contains("@"))
                {
                    UserDTO dtoModel = new UserDTO()
                    {
                        Email = parameterModel.Email,
                        Password = parameterModel.Password,
                        FirstName = parameterModel.FirstName ?? string.Empty,
                        LastName = parameterModel.LastName ?? string.Empty,
                        SecondName = parameterModel.SecondName ?? string.Empty,
                        Birthday = DateTime.Parse(parameterModel.Birthday),
                        UserName = parameterModel.UserName ?? string.Empty
                    };

                    var isSignable = _userService.CheckUser(dtoModel, _configuration["Authentication:SaltPassword"]);
                    if (!isSignable)
                    {
                        var insertResult = _userService.InserToUser(dtoModel, _configuration["Authentication:SaltPassword"]);

                        if (insertResult)
                        {
                            response = RedirectToAction("SignIn", new { parameterModel = parameterModel });
                        }
                    }
                }
            }

            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(string userEmail)
        {
            IActionResult response = BadRequest("İşlem yapılırken bir hata oluştu. Lütfen tekrar deneyiniz!");

            if (!string.IsNullOrEmpty(userEmail) && userEmail.Contains("@"))
            {
                var user = _userService.GetUserByEmail(userEmail);

                if (user != null)
                {
                    string isMailSended = _userService.SendRememberMail(user, _configuration["Authentication:SaltPassword"]);

                    if (!string.IsNullOrEmpty(isMailSended))
                    {
                        response = Ok($"Mail Gönderildi! Şifre : {isMailSended}");
                    }
                }
            }

            return response;
        }
    }
}
