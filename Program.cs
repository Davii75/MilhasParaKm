double em_milhas;
double em_km;

Console.Write("Entre com a medida (em milhas): ");
em_milhas = Convert.ToDouble(Console.ReadLine()!);
em_km = em_milhas * 1.609;
Console.Clear();

Console.WriteLine($"Medida em milhas: {em_milhas}");
Console.WriteLine($"Medida em km: {em_km}");
