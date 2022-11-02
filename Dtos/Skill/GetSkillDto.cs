using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Skill
{
    public class GetSkillDto
    {
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; }

    }
}