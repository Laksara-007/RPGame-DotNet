using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public Byte[] passwordSalt { get; set; }
        public byte[] passwordHash { get; set; }

        public List<Character>? Characters { get; set; }
    }
}