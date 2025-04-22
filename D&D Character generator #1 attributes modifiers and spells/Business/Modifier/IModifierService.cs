using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier
{
    public interface IModifierService
    {
        int GetModifier(int abilityScore);
    }
}
