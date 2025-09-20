
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SafeVault;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserRepository _repo;
    public UsersController(UserRepository repo) => _repo = repo;

    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto dto)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        var id = await _repo.CreateAsync(dto.Username, dto.Email, "User");
        return CreatedAtAction(nameof(GetByEmail), new { email = dto.Email }, new { id, dto.Username, dto.Email });
    }

    [HttpGet("{email}")]
    [Authorize] // any authenticated user
    public async Task<IActionResult> GetByEmail([FromRoute] string email)
    {
        var user = await _repo.FindByEmailAsync(email);
        return user is null ? NotFound() : Ok(user);
    }

    [HttpPost("admin/rotate-keys")]
    [Authorize(Roles = "Admin")]
    public IActionResult RotateKeys()
    {
        // rotate keys…
        return Ok(new { status = "rotated" });
    }
}
