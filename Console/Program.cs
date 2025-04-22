// See https://aka.ms/new-console-template for more information
using DnDCharacterGenerator1AttributesModifiersAndSpells;

Console.WriteLine("D&D Character generator #1 attributes modifiers and spells");
Console.WriteLine(new string ('=',60));

CharacteristicService charService = new();

Console.WriteLine("\nAbilityScore is 0");
Console.WriteLine(charService.CalculateAttribute(0).ToString());

Console.WriteLine("\nAbilityScore is 1");
Console.WriteLine(charService.CalculateAttribute(1).ToString());

Console.WriteLine("\nAbilityScore is 5");
Console.WriteLine(charService.CalculateAttribute(5).ToString());

Console.WriteLine("\nAbilityScore is 10");
Console.WriteLine(charService.CalculateAttribute(10).ToString());

Console.WriteLine("\nAbilityScore is 20");
Console.WriteLine(charService.CalculateAttribute(20).ToString());

Console.WriteLine("\nAbilityScore is 40");
Console.WriteLine(charService.CalculateAttribute(40).ToString());

Console.WriteLine("\nAbilityScore is 80");
Console.WriteLine(charService.CalculateAttribute(80).ToString());
