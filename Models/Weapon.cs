using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Fists";
        public int Damage { get; set; } = 10;
        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}