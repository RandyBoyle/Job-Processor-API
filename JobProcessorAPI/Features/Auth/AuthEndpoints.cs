using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JobProcessorAPI.Features.Auth
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {

            app.MapPost("/login", () =>
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "api-user")
            };

            var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("super_secret_dev_key_1234567890123456")
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return Results.Ok(new
                {
                token = tokenString
                });
            });
        
        }
    }
}
