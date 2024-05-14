using DRHanannProject.Models;

namespace DRHanannProject.repository
{
    public class UserRepo : IUserRepo
    {
        private readonly DataContext _context;
        public UserRepo(DataContext context)
        {

            _context = context;

        }
        public bool createuser(string username, string password)
        {
           user User=_context.users.Where(u=>u.email == username).FirstOrDefault();
            
            if(User == null)
            {
                user UserToAdd=new user() { email = username, password = password };
                _context.users.Add(UserToAdd);
                return _context.SaveChanges()>0?true:false;
            }
            else
            {
                return false;
            }
        }

        public user GetUser(string username, string password)
        {
            user User=_context.users.Where(u=>u.email == username&&u.password==password).FirstOrDefault();
            return User;
        }
    }
}
