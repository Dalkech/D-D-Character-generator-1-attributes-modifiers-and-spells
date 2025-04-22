using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.ExtraSpellService
{
    public interface IExtraSpellsService
    {
        int[] GetExtraSpells(int abilityScore);
    }
}
