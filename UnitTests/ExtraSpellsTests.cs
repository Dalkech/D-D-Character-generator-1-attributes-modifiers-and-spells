using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.ExtraSpellService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class ExtraSpellsTests
    {
        [Theory]
        [InlineData(0, new int [] {})]
        [InlineData(18, new int[] { 1,1,1,1 })]
        [InlineData(20, new int[] { 2,1,1,1,1 })]
        public void TestGetExtraSpells(int abilityScore, int[] expected)
        {
            //arrange
            ExtraSpellsService extraSpellsService = new();

            //act 
            var extraSpells = extraSpellsService.GetExtraSpells(abilityScore);

            //Assert
            Assert.Equal(expected, extraSpells);
        }
    }
}
