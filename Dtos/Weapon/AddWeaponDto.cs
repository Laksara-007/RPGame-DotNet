using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Weapon
{
    public class AddWeaponDto
    {
        public string Name { get; set; } = "Fists";
        public int Damage { get; set; } = 10;
        public int CharacterId { get; set; }
    }
}