using Training_Management.Context;
using Training_Management.Models;

namespace Training_Management.Repository
{
    public class UserRepository : UserInterface
    {

        TrainingDbContext _db;

        public UserRepository(TrainingDbContext db)
        {
            _db = db;
        }
        public User Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;

        }

        public int Delete(int id)
        {
            User obj = GetUserById(id);
            if (obj != null)
            {
                _db.Users.Remove(obj);
                _db.SaveChanges();
            }
            return 1;
        }

        

        public int Edit(int id,User user)
        {
            User obj = GetUserById(id);
            if (obj != null)
            {
                foreach (User temp in _db.Users)
                {
                    if (temp.UserId == id)
                    {
                        temp.USerName = user.USerName;
                        temp.Address = user.Address;
                        temp.ContactNo = user.ContactNo;
                        temp.Email = user.Email;
                        temp.ManagerId = user.ManagerId;
                       

                    }
                }
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }

        public User GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(x => x.UserId == id);
        }

        public List<User> GetUsers()
        {
           return _db.Users.ToList();
        }

        public User ValidateUser(string uname, string password)
        {
            return _db.Users.FirstOrDefault(x => x.Email.Equals(uname) && x.Password.Equals(password));



        }

      
    }
}
