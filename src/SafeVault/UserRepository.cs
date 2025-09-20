
using Dapper;
using System.Data;

namespace SafeVault;

public class UserRepository
{
    private readonly IDbConnection _db;
    public UserRepository(IDbConnection db) => _db = db;

    public async Task<User?> FindByEmailAsync(string email)
    {
        const string sql = @"SELECT Id, Username, Email, Role FROM Users WHERE Email = @Email";
        return await _db.QueryFirstOrDefaultAsync<User>(sql, new { Email = email });
    }

    public async Task<int> CreateAsync(string username, string email, string role)
    {
        const string sql = @"INSERT INTO Users(Username, Email, Role) VALUES(@Username, @Email, @Role);
                             SELECT CAST(SCOPE_IDENTITY() as int);";
        return await _db.ExecuteScalarAsync<int>(sql, new { Username = username, Email = email, Role = role });
    }
}

public record User(int Id, string Username, string Email, string Role);
