using ProjectManagementSystem.Core.Domain.Enums;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role UserRole { get; set; }

        public User(string name, Role role)
        {
            Name = name;
            UserRole = role;
        }
    }
}
