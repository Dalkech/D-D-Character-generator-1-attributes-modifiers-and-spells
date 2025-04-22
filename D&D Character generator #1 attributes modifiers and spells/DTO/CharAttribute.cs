namespace DnDCharacterGenerator1AttributesModifiersAndSpells.DTO
{
    internal class CharAttribute(int modifier, int maximumSpellLevel, int[] extraSpells)
    {
        private int modifier = modifier;
        private int maximumSpellLevel = maximumSpellLevel;
        private int[] extraSpells = extraSpells;

        public override string ToString()
        {
            return "modifier: " + modifier + ", maximumSpellLevel: " + maximumSpellLevel + ", extraSpells : " + string.Format("[{0}]", string.Join(", ", extraSpells));
        }
    }
}