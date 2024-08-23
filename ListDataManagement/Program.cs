List<string> names = ["Jeff", "Joy", "Nikita"];
foreach (var name in names)
{
	Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
	Console.WriteLine($"Hello {name.ToUpper()}!");
}
