using DRHanannProject.Models;

namespace DRHanannProject
{
    public interface IUserRepo
{
        bool createuser (string username, string password);
        user GetUser (string username,string password);
}
}
