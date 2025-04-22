using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.ExtraSpellService.Services
{
    public sealed class ExtraSpellsService : IExtraSpellsService
    {
        private const int MaxSpellLevel = 9;
        private const int MaxNumberOfSpellsByLv = 4;
        private const int MinNumberOfSpell = 1;

        public int[] GetExtraSpells(int abilityScore)
        {
            if (abilityScore < 12)
                return [];

            int abilityModifier = (abilityScore - 10) / 2;
            int maxSpellLevel = (abilityModifier > MaxSpellLevel ? MaxSpellLevel : abilityModifier);
            int[] extraSpells = new int[maxSpellLevel];

            int slotValue = abilityModifier > MaxSpellLevel 
                ? (abilityModifier - MaxSpellLevel) / MaxNumberOfSpellsByLv + 1
                : MinNumberOfSpell;
            int numberOfAssignation = abilityModifier > MaxSpellLevel ? 
                (abilityModifier - MaxSpellLevel) % MaxNumberOfSpellsByLv
                :0; 

            for(int i = maxSpellLevel-1; i > -1; i--, numberOfAssignation++)
            {
                if(numberOfAssignation == MaxNumberOfSpellsByLv)
                {
                    slotValue++;
                    numberOfAssignation = 0;
                }

                extraSpells[i]+=slotValue;
            }

            return extraSpells;
        }
    }
}
