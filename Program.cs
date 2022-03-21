double km, milhas;

Console.WriteLine("digite as milhas por favor:");
milhas = Convert.ToDouble(Console.ReadLine());

km = milhas * 1.609;

Console.WriteLine($"a medida em quilometros é: {km:N3} km");
