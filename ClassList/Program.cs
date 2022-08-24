Eric p1 = new();
Cowman e1 = new();
Cowman e2 = new();
Cowman e3 = new();

p1.sanity = 74;
e1.target = "Eric";
e2.name = "Armsy";
e3.name = "Virginia";

Console.WriteLine("Player name: " + p1.name);

Console.WriteLine("Enemy name: " + e1.name);
Console.WriteLine("Enemy name: " + e2.name);
Console.WriteLine("Enemy name: " + e3.name);

Console.WriteLine(e1.name + " target: " + e1.target);
Console.WriteLine(e2.name + " target: " + e2.target);
Console.WriteLine(e3.name + " target: " + e3.target);

Console.WriteLine("Player sanity: " + p1.sanity + "%");

Console.ReadLine();