using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.Modifier
{
    public interface IModifierService
    {
        int GetModifier(int abilityScore);
    }
}
