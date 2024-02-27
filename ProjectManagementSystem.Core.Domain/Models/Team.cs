using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }

        public void AddMember(User user)
        {
            Members.Add(user);
        }
    }
}
