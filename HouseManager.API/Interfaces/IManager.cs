namespace HouseManager.API.Controllers.Interfaces;

public interface IManager
{
    Task<IUser> DeleteUser(Guid id);

    Task<IUser> ReassignUser(Guid id, string role);
}