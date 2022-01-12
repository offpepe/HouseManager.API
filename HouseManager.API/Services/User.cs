using System.ComponentModel.DataAnnotations;
using HouseManager.API.Controllers.Interfaces;

namespace HouseManager.API.Services;

public class User : IUser
{
    public User()
    {
    }
    [Key]
    public Guid Id { get; }
    [Required]
    [StringLength(100)]
    public string Nome { get; set; }
    [Required]
    [StringLength(50)]
    public string Email { get; set; }
    [Required]
    public int Idade { get; set; }
    [Required]
    [StringLength(50)]
    public int Cargo { get; set; }
    
    public Task<IUser> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<IUser> GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public Task<IUser> ValidatePassword(string password)
    {
        throw new NotImplementedException();
    }

    public Task<IUser> RegisterUser(string name, string email, string role, string password)
    {
        throw new NotImplementedException();
    }

    public Task<IUser> UpdateUser(string? name, string? email, string? role, string? password)
    {
        throw new NotImplementedException();
    }
}