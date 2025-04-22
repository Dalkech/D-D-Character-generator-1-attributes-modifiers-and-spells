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
        [InlineData(3, -4)]
        [InlineData(4, -3)]
        //edge test, reaching 0 modifier
        [InlineData(10, 0)]
        [InlineData(20, 5)]
        //edge test with higher abilityScore
        [InlineData(56, 23)]
        [InlineData(57, 23)]
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