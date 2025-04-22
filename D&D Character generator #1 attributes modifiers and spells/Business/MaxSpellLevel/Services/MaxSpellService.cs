using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.MaxSpellLevel.Services
{
    public sealed class MaxSpellService : IMaxSpellService
    {
        public int GetMaximumSpellLevel(int abilityScore)
        {
            if (abilityScore < MaxSpellConstants.MinAbilityScore)
                return - 1;

            if (abilityScore == MaxSpellConstants.MinAbilityScore)
                return 0;

            int maximumSpellLevel = 0;
            return maximumSpellLevel;
        }
    }
}
