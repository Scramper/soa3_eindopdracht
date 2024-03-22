﻿
namespace ProjectManagementSystem.Core.Domain.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Private { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();
    }
}
