using DnDCharacterGenerator1AttributesModifiersAndSpells.Business.ExtraSpellService.Services;
using DnDCharacterGenerator1AttributesModifiersAndSpells.Business.MaxSpellLevel.Services;
using DnDCharacterGenerator1AttributesModifiersAndSpells.Business.Modifier.Services;
using DnDCharacterGenerator1AttributesModifiersAndSpells.DTO;

namespace DnDCharacterGenerator1AttributesModifiersAndSpells
{

    public sealed class CharacteristicService
    {
        private readonly ModifierService modifierService;
        private readonly MaxSpellService maxSpellService;
        private readonly ExtraSpellsService extraSpellService;

        public CharacteristicService()
        {
            this.modifierService = new ModifierService();
            this.maxSpellService = new MaxSpellService();
            this.extraSpellService = new ExtraSpellsService(); 
        }

        public object CalculateAttribute(int abilityScore)
        {
            return new CharAttribute(modifierService.GetModifier(abilityScore), maxSpellService.GetMaximumSpellLevel(abilityScore), extraSpellService.GetExtraSpells(abilityScore));
        }
    }
}
