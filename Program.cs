while (true)
{
	Console.Clear();
	Console.WriteLine("MM   ◙◙  ◙◙ ◙◙◙◙ ◙◙   ◙◙◙◙   MM");
	Console.WriteLine("AA   ◙◙ ◙◙  ◙◙   ◙◙    ◙◙    AA");
	Console.WriteLine("II   ◙◙◙◙   ◙◙◙◙ ◙◙    ◙◙    II");
	Console.WriteLine("AA   ◙◙ ◙◙  ◙◙   ◙◙    ◙◙    AA");
	Console.WriteLine("S2   ◙◙  ◙◙ ◙◙◙◙ ◙◙◙◙ ◙◙◙◙   S2");
	Console.WriteLine("============================");
	Console.WriteLine("====== Calculadora C# ======");
	Console.WriteLine("============================");
	double valor1, valor2;
	int op;
	while (true)
	{
		Console.Write("Digite o primeiro valor: ");
		if (double.TryParse(Console.ReadLine(), out valor1)) break;
		Console.WriteLine("Valor inválido. Digite um número.");
	}
	while (true)
	{
		Console.Write("Digite o segundo valor: ");
		if (double.TryParse(Console.ReadLine(), out valor2)) break;
		Console.WriteLine("Valor inválido. Digite um número.");
	}
	Console.WriteLine("-------------------------");
	Console.WriteLine("--- 1 = adição ----------");
	Console.WriteLine("--- 2 = subtração -------");
	Console.WriteLine("--- 3 = multiplicação ---");
	Console.WriteLine("--- 4 = divisão ---------");
	Console.WriteLine("--- 0 = sair ------------");
	Console.WriteLine("-------------------------");
	while (true)
	{
		Console.Write("Digite a operação desejada: ");
		if (int.TryParse(Console.ReadLine(), out op) && op >= 0 && op <= 4) break;
		Console.WriteLine("Opção inválida. Digite um número de 0 a 4.");
	}
	if (op == 0)
	{
		Console.WriteLine("Encerrando...");
		break;
	}
	switch (op)
	{
		case 1:
			Console.WriteLine("Resultado: " + (valor1 + valor2));
			break;
		case 2:
			Console.WriteLine("Resultado: " + (valor1 - valor2));
			break;
		case 3:
			Console.WriteLine("Resultado: " + (valor1 * valor2));
			break;
		case 4:
			Console.WriteLine("Resultado: " + (valor1 / valor2));
			break;
	}
	Console.WriteLine("\nPressione qualquer tecla para continuar...");
	Console.ReadKey();
}