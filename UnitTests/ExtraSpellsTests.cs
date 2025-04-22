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
        [InlineData(12, new int[] { 1 })]
        [InlineData(18, new int[] { 1,1,1,1 })]
        [InlineData(20, new int[] { 2,1,1,1,1 })]
        [InlineData(22, new int[] { 2,2,1,1,1,1 })]
        [InlineData(28, new int[] { 3, 2,2,2,2, 1,1,1,1 })]
        [InlineData(29, new int[] { 3, 2, 2, 2, 2, 1, 1, 1, 1 })]
        [InlineData(30, new int[] { 3, 3, 2, 2, 2, 2, 1, 1, 1 })]
        [InlineData(36, new int[] { 4, 3, 3, 3, 3, 2, 2, 2, 2 })]
        [InlineData(37, new int[] { 4, 3, 3, 3, 3, 2, 2, 2, 2 })]
        [InlineData(40, new int[] { 4, 4, 4, 3, 3, 3, 3, 2, 2 })]
        [InlineData(42, new int[] { 4, 4, 4, 4, 3, 3, 3, 3, 2 })]
        [InlineData(44, new int[] { 5, 4 ,4,4,4, 3,3,3,3 })]
        // in theory reaching absurd value with 50 and 52
        [InlineData(50, new int[] { 5, 5, 5, 5, 4, 4, 4, 4, 3 })]
        [InlineData(52, new int[] { 6, 5, 5, 5, 5, 4, 4, 4, 4 })]
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
