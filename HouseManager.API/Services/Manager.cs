using System.ComponentModel.DataAnnotations;
using HouseManager.API.Controllers.Interfaces;

namespace HouseManager.API.Services;

public class Manager : User, IManager
{
    public Manager()
    {
        
    }
    [Required]
    public Responsabilities? Responsabilities { get; set; }

    public Task<IUser> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IUser> ReassignUser(Guid id, string role)
    {
        throw new NotImplementedException();
    }
}