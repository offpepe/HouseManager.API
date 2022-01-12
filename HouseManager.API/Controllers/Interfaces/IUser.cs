namespace HouseManager.API.Controllers.Interfaces;

public interface IUser
{
    Task<IUser> GetAllUsers();

    Task<IUser> GetUserByEmail(string email);

    Task<IUser> ValidatePassword(string password);

    Task<IUser> RegisterUser(string name, string email, string role, string password);

    Task<IUser> UpdateUser(string? name, string? email, string? role, string? password);
}