using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.MaxSpellLevel
{
    public interface IMaxSpellService
    {
        int GetMaximumSpellLevel(int abilityScore);
    }
}
