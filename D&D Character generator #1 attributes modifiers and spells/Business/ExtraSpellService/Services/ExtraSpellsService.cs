using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.ExtraSpellService.Services
{
    public sealed class ExtraSpellsService : IExtraSpellsService
    {
        public int[] GetExtraSpells(int abilityScore)
        {
            if (abilityScore < ExtraSpellsConstants.minLevelForExtraSpells)
                return [];

            List<int> extraSpells = [];
            int nextLevelForExtraStep = ExtraSpellsConstants.minLevelForExtraSpells + ExtraSpellsConstants.extraSpellsLevelStep;
            int currentSpellLevel = 1;

            for (int i = ExtraSpellsConstants.minLevelForExtraSpells; i <= abilityScore; i += ExtraSpellsConstants.extraSpellsStep)
            {
                if (i == nextLevelForExtraStep)
                {
                    nextLevelForExtraStep += ExtraSpellsConstants.extraSpellsLevelStep;
                    currentSpellLevel++;
                }

                extraSpells.Add(currentSpellLevel);
            }

            extraSpells.Reverse();
            return extraSpells.ToArray();
        }
    }
}
