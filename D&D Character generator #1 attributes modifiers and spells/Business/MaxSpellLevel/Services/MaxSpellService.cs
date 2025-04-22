using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.MaxSpellLevel.Services
{
    public sealed class MaxSpellService : IMaxSpellService
    {
        private const int MinAbilityScore = 10;
        private const int MinSpellLevel = 1;
        private const int AbilityScoreStep = 2;
        private const int SpellLevelStep = 4;
        public int GetMaximumSpellLevel(int abilityScore)
        {
            if (abilityScore < MinAbilityScore)
                return -1;

            if (abilityScore == MinAbilityScore
                || abilityScore == MinAbilityScore + 1)
                return 0;            

            int maximumSpellLevel = CalculateMaximumSpellLevel(abilityScore);
            return maximumSpellLevel;
        }

        private int CalculateMaximumSpellLevel(int abilityScore) => 
            MinSpellLevel + (abilityScore - MinAbilityScore) / AbilityScoreStep / SpellLevelStep;
    }
}
