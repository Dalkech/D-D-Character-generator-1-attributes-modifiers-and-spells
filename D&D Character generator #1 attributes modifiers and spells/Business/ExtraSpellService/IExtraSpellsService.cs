using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells.Business.ExtraSpellService
{
    public interface IExtraSpellsService
    {
        int[] GetExtraSpells(int abilityScore);
    }
}
