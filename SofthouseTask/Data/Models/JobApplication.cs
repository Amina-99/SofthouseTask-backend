﻿
namespace SofthouseTask.Data.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }
        public byte[] CV { get; set; }
        public bool IsDeleted { get; set; }
    }
}
