string[] snacks = { "sushi", "pitzza", "burger", "chickenwings", "asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0,snacks.Length);

Console.WriteLine($"Tonight We are going to eat {snacks[randomIndex]}.");
