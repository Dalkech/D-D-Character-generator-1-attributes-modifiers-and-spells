using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier;
using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier.Services;

namespace UnitTests
{
    public class ModifierTests
    {
        private readonly ModifierService modifierService = new();

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, -5)]
        public void TestGetModifier(int scoreAttribute, int expected)
        {
            //arrange
            IModifierService modifierService = new ModifierService();

            //act
            int modifier = modifierService.GetModifier(scoreAttribute);

            //assert
            Assert.Equal(expected, modifier);
        }
       
    }
}