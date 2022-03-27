using Classes;

Console.WriteLine($"Soma de 1 + 2: {Calculadora.Somar(1,2)}");
Console.WriteLine($"Subtracao de 10 - 2: {Calculadora.Subtrair(10, 2)}");
Console.WriteLine($"Multiplicacao de 3 * 6: {Calculadora.Multiplicar(3, 6)}");

Carro carro1 = new Carro();
carro1.Nome = "Uno";
carro1.Marca = "Fiat";

Carro carro2 = new Carro("Joy", "1.0", "Urbano", "GM");

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Modelo {carro1.Nome}, Motorizacao: {carro1.Motorizacao}, Categoria: {carro1.Categoria}, Fabricante: {carro1.Marca}");
Console.WriteLine($"Modelo {carro2.Nome}, Motorizacao: {carro2.Motorizacao}, Categoria: {carro2.Categoria}, Fabricante: {carro2.Marca}");

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Soma de 1 + 2 + 3: {Calculadora.Somar(1, 2, 3)}");
Console.WriteLine($"Subtracao de 10 - 2 - 1: {Calculadora.Subtrair(10, 2, 1)}");
Console.WriteLine($"Multiplicacao de 3 * 6 * 4: {Calculadora.Multiplicar(3, 6, 4)}");