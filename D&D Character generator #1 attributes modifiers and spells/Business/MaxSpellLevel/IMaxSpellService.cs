using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.MaxSpellLevel
{
    public interface IMaxSpellService
    {
        int GetMaximumSpellLevel(int abilityScore);
    }
}
