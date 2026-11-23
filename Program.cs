// Game koch = new Game("koch run", "16.10.2077", "runner", 100.0);

// Console.WriteLine(">>> игра 1 <<<");
// Console.WriteLine($"название: {koch.Name}");
// Console.WriteLine($"жанр: {koch.    Genre}");
// Console.WriteLine($"дата релиза: {koch.Releasedate}");
// Console.WriteLine($"рейтинг: {koch.rating}");

// Console.WriteLine();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");