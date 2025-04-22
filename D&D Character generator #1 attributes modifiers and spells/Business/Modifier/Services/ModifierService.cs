using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.Modifier.Services
{
    public sealed class ModifierService : IModifierService
    {
        private const int MinModifier = -5;
        private const int ModifierStep = 2;
        private const int ZeroAbilityScoreModifier = 0;
        public int GetModifier(int abilityScore)
        {
            if (abilityScore == 0)
                return ZeroAbilityScoreModifier;

            return MinModifier + (abilityScore / ModifierStep);
        }
    }
}
