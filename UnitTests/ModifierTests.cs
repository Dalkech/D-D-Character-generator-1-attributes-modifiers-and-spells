using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier;
using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.Modifier.Services;

namespace UnitTests
{
    public class ModifierTests
    {
        [Fact]
        public void TestFor0()
        {
            //arrange
            IModifierService modifierService = new ModifierService();

            //act
            int modifier = modifierService.GetModdifier(0);

            //assert
            int expected = 0;
            Assert.Equal(expected, modifier);
        }
    }
}