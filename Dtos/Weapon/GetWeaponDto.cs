using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Weapon
{
    public class GetWeaponDto
    {
        public string Name { get; set; } = "Fists";
        public int Damage { get; set; } = 10;

    }
}