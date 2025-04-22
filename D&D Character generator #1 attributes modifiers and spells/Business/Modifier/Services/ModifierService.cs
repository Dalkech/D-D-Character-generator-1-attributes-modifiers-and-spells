using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier.Services
{
    public sealed class ModifierService : IModifierService
    {
        public int GetModifier(int abilityScore)
        {
            if (abilityScore == 0)
                return ModifierConstants.ZeroAbilityScoreModifier;

            return ModifierConstants.MinModifier + (abilityScore / ModifierConstants.ModifierStep);
        }
    }
}
