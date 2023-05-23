namespace Training_Management.Models
{
    public class User
    {

       
        public int UserId { get; set; }
        public string USerName { get; set; }

        public string Email{ get; set; }
        public string ContactNo{ get; set; }

        public string Address{ get; set; }
        public Boolean IsActive { get; set; }

        public string Password { get; set; }
        public role Role { get; set; }
        public int ManagerId { get; set; }

        public enum role
        {
            Manager,
            Employee
        }

        








    }
}
