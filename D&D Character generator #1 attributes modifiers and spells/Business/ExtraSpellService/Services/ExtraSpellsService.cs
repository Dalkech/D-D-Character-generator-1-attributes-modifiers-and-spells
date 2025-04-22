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
            if (abilityScore < 12)
                return [];

            int abilityModifier = (abilityScore - 10) / 2;
            int maxSpellLevel = (abilityModifier > 9 ? 9 : abilityModifier);
            int[] extraSpells = new int[maxSpellLevel];
            int slotValue = abilityModifier > 9 ? (abilityModifier - 9) / 4 + 1
                :1;

            int numberOfAssignation = abilityModifier > 9 ? 
                (abilityModifier - 9) % 4
                : 0; 

            for(int i = maxSpellLevel-1; i > -1; i--, numberOfAssignation++)
            {
                if(numberOfAssignation == 4)
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
