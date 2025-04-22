using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier;
using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier.Services;

namespace UnitTests
{
    public class ModifierTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, -5)]
        [InlineData(2, -4)]
        public void TestGetModifier(int scoreAttribute, int expected)
        {
            //arrange
            ModifierService modifierService = new();

            //act
            int modifier = modifierService.GetModifier(scoreAttribute);

            //assert
            Assert.Equal(expected, modifier);
        }
    }
}