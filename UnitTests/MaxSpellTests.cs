using DnDCharacterGenerator1AttributesModifiersAndSpells.Business.MaxSpellLevel.Services;
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
        [InlineData(14, 1)]
        [InlineData(15, 1)]
        [InlineData(44, 5)]
        [InlineData(45, 5)]
        //testing higher score
        [InlineData(80, 9)]
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
