using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // One to Many
        public List<Character>? Characters { get; set; }
    }
}