namespace CalculadoraDeCalorias;

public class Calculadora
{
    
    public void AguardarEnter()
    {
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }


    public void PerderPeso()
    {
        int idade;
        decimal altura;
        decimal peso;
        char genero;
        int opcao2 = 0;

        Console.Write("Digite sua idade: ");
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Idade inválida");
            Console.Write("Digite sua idade: ");
        }
        
        Console.Write("Digite sua altura em cm (ex: 175): ");
        while (!decimal.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Altura inválida");
            Console.Write("Digite sua altura em cm (ex: 175): ");
        }

        Console.Write("Digite seu peso em kg (ex: 65): ");
        while (!decimal.TryParse(Console.ReadLine(), out peso))
        {
            Console.WriteLine("Peso inválido");
            Console.Write("Digite seu peso em kg (ex: 65): ");
        }

        Console.Write("Digite seu gênero (M/F): ");
        while (!char.TryParse(Console.ReadLine()?.ToUpper(), out genero) || (genero != 'M' && genero != 'F'))
        {
            Console.WriteLine("Gênero inválido! Digite apenas M ou F.");
            Console.Write("Digite seu gênero (M/F): ");
        }
        
        Console.Clear();


        while (opcao2 != 1 && opcao2 != 2 && opcao2 != 3)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Você é: ");
            Console.WriteLine("1- Sedentário(a)");
            Console.WriteLine("2- Levemente ativo(a)");
            Console.WriteLine("3- Ativo(a)");
            Console.WriteLine("==================");

            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao2))
            {
                Console.WriteLine("Por favor, digite apenas números (1, 2 ou 3).");
            }
            else if (opcao2 != 1 && opcao2 != 2 && opcao2 != 3) 
            {
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 3.");
            }
        }

        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario - 500:f0} a {sedentario - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente - 500:f0} a {levemente - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo - 500:f0} a {ativo - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario - 500:f0} a {sedentario - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente - 500:f0} a {levemente - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo - 500:f0} a {ativo - 400:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    public void GanharPeso()
    {
        int idade;
        decimal altura;
        decimal peso;
        char genero;
        int opcao2 = 0;

        Console.Write("Digite sua idade: ");
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Idade inválida");
            Console.Write("Digite sua idade: ");
        }
        
        Console.Write("Digite sua altura em cm (ex: 175): ");
        while (!decimal.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Altura inválida");
            Console.Write("Digite sua altura em cm (ex: 175): ");
        }

        Console.Write("Digite seu peso em kg (ex: 65): ");
        while (!decimal.TryParse(Console.ReadLine(), out peso))
        {
            Console.WriteLine("Peso inválido");
            Console.Write("Digite seu peso em kg (ex: 65): ");
        }

        Console.Write("Digite seu gênero (M/F): ");
        while (!char.TryParse(Console.ReadLine()?.ToUpper(), out genero) || (genero != 'M' && genero != 'F'))
        {
            Console.WriteLine("Gênero inválido! Digite apenas M ou F.");
            Console.Write("Digite seu gênero (M/F): ");
        }
        
        Console.Clear();


        while (opcao2 != 1 && opcao2 != 2 && opcao2 != 3)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Você é: ");
            Console.WriteLine("1- Sedentário(a)");
            Console.WriteLine("2- Levemente ativo(a)");
            Console.WriteLine("3- Ativo(a)");
            Console.WriteLine("==================");

            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao2))
            {
                Console.WriteLine("Por favor, digite apenas números (1, 2 ou 3).");
            }
            else if (opcao2 != 1 && opcao2 != 2 && opcao2 != 3) 
            {
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 3.");
            }
        }

        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario + 300:f0} a {sedentario + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente + 300:f0} a {levemente + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo + 300:f0} a {ativo + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario + 300:f0} a {sedentario + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente + 300:f0} a {levemente + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo + 300:f0} a {ativo + 500:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    public void ManterPeso()
    {
        int idade;
        decimal altura;
        decimal peso;
        char genero;
        int opcao2 = 0;

        Console.Write("Digite sua idade: ");
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Idade inválida");
            Console.Write("Digite sua idade: ");
        }
        
        Console.Write("Digite sua altura em cm (ex: 175): ");
        while (!decimal.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Altura inválida");
            Console.Write("Digite sua altura em cm (ex: 175): ");
        }

        Console.Write("Digite seu peso em kg (ex: 65): ");
        while (!decimal.TryParse(Console.ReadLine(), out peso))
        {
            Console.WriteLine("Peso inválido");
            Console.Write("Digite seu peso em kg (ex: 65): ");
        }

        Console.Write("Digite seu gênero (M/F): ");
        while (!char.TryParse(Console.ReadLine()?.ToUpper(), out genero) || (genero != 'M' && genero != 'F'))
        {
            Console.WriteLine("Gênero inválido! Digite apenas M ou F.");
            Console.Write("Digite seu gênero (M/F): ");
        }
        
        Console.Clear();


        while (opcao2 != 1 && opcao2 != 2 && opcao2 != 3)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Você é: ");
            Console.WriteLine("1- Sedentário(a)");
            Console.WriteLine("2- Levemente ativo(a)");
            Console.WriteLine("3- Ativo(a)");
            Console.WriteLine("==================");

            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao2))
            {
                Console.WriteLine("Por favor, digite apenas números (1, 2 ou 3).");
            }
            else if (opcao2 != 1 && opcao2 != 2 && opcao2 != 3) 
            {
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 3.");
            }
        }

        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {sedentario:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {levemente:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {ativo:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {sedentario:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {levemente:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo:f0} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {ativo:f0} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m:f0} ml a {peso * 40m:f0} ml de água/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }
}
