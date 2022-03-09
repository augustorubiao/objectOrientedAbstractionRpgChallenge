using objectOrientedRpgAbstraction.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight", 250, 100);
WhiteWizard jennica = new WhiteWizard("Jennica", 23, "White Wizard", 120, 300);
Ninja wedge = new Ninja("Wedge", 20, "Ninja", 180, 200);
BlackWizard topapa = new BlackWizard("Topapa", 25, "Black Wizard", 140, 280);

Console.WriteLine("Welcome to the heroes atributes interface!\n\nDown below, you will see the attributes of your party.\n\nPress any key to continue.\n");

Console.ReadKey();

Console.WriteLine($"{arus.HeroType}\n{arus.Name} Lvl. {arus.Level}");
Console.WriteLine($"HP: {arus.HP} MP: {arus.MP}\n");

Console.WriteLine($"{jennica.HeroType}\n{jennica.Name} Lvl. {jennica.Level}");
Console.WriteLine($"HP: {jennica.HP} MP: {jennica.MP}\n");

Console.WriteLine($"{wedge.HeroType}\n{wedge.Name} Lvl. {wedge.Level}");
Console.WriteLine($"HP: {wedge.HP} MP: {wedge.MP}\n");

Console.WriteLine($"{topapa.HeroType}\n{topapa.Name} Lvl. {topapa.Level}");
Console.WriteLine($"HP: {topapa.HP} MP: {topapa.MP}\n");

Console.WriteLine("Now we will check the strings for \"Attack\" method of each character.\n\nPress Enter to continue.");
Console.ReadLine();

Console.WriteLine(arus.Attack());
Console.WriteLine(jennica.Attack(7));
Console.WriteLine(wedge.Attack());
Console.WriteLine(topapa.Attack());
Console.ReadKey();