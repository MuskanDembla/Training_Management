using Training_Management.Models;

namespace Training_Management
{
    public interface UserInterface
    {

        List<User> GetUsers();
        User Create(User user);
        User GetUserById(int id);
        int Delete(int id);
        int Edit(int id, User user);
        User ValidateUser(string email, string password);
    }
}
