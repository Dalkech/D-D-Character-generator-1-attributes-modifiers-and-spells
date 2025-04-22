using D_D_Character_generator__1_attributes_modifiers_and_spells.Business.MaxSpellLevel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MaxSpellTests
    {
        [Theory]
        [InlineData(0, -1)]
        [InlineData(9, -1)]
        [InlineData(10, 0)]
        [InlineData(11, 0)]
        [InlineData(12, 1)]
        [InlineData(13, 1)]
        [InlineData(14, 2)]
        [InlineData(15, 2)]
        public void TestGetMaxSpellLevel(int abiltyScore, int expected)
        {
            // arrange
            MaxSpellService maxSpellService = new();

            //act
            int maxSpellLevel = maxSpellService.GetMaximumSpellLevel(abiltyScore);
            //assert

            Assert.Equal(expected, maxSpellLevel);
        }
    }
}
