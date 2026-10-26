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
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em cm (ex: 175): ");
        decimal altura = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu peso em kg (ex: 65): ");
        decimal peso = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu gênero (M/F): ");
        char genero = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("\n");
        
        Console.Clear();

        Console.WriteLine("==================");
        Console.WriteLine("Você é: ");
        Console.WriteLine("1- Sedentario");
        Console.WriteLine("2- Levemente ativo");
        Console.WriteLine("3- Ativo");
        Console.WriteLine("==================");

        Console.Write("Opção: ");
        int opcao2 = int.Parse(Console.ReadLine());

        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario - 500} a {sedentario - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente - 500} a {levemente - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo - 500} a {ativo - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario - 500} a {sedentario - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente - 500} a {levemente - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo - 500} a {ativo - 400} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção invalida");
        }
    }

    public void GanharPeso()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em cm (ex: 175): ");
        decimal altura = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu peso em kg (ex: 65): ");
        decimal peso = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu gênero (M/F): ");
        char genero = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("\n");

        Console.Clear();

        Console.WriteLine("==================");
        Console.WriteLine("Você é: ");
        Console.WriteLine("1- Sedentario");
        Console.WriteLine("2- Levemente ativo");
        Console.WriteLine("3- Ativo");
        Console.WriteLine("==================");

        Console.Write("Opção: ");
        int opcao2 = int.Parse(Console.ReadLine());


        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario + 300} a {sedentario + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente + 300} a {levemente + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo + 300} a {ativo + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {sedentario + 300} a {sedentario + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {levemente + 300} a {levemente + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir cerca de {ativo + 300} a {ativo + 500} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção invalida");
        }
    }

    public void ManterPeso()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em cm (ex: 175): ");
        decimal altura = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu peso em kg (ex: 65): ");
        decimal peso = decimal.Parse(Console.ReadLine());

        Console.Write("Digite seu gênero (M/F): ");
        char genero = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("\n");

        Console.Clear();

        Console.WriteLine("==================");
        Console.WriteLine("Você é: ");
        Console.WriteLine("1- Sedentario");
        Console.WriteLine("2- Levemente ativo");
        Console.WriteLine("3- Ativo");
        Console.WriteLine("==================");

        Console.Write("Opção: ");
        int opcao2 = int.Parse(Console.ReadLine());


        decimal resultado = (10m*peso) + (6.25m * altura) - (5m * idade) + 5m;
        decimal resultado2 = (10m*peso) + (6.25m * altura) - (5m * idade) - 161;

        Console.Clear();

        if (opcao2 == 1 && genero == 'M')
        {
            decimal sedentario = resultado * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {sedentario} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'M')
        {
            decimal levemente = resultado * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {levemente} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'M')
        {
            decimal ativo = resultado * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {ativo} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 1 && genero == 'F')
        {
            decimal sedentario = resultado2 * 1.2m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {sedentario} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {sedentario} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 2 && genero == 'F')
        {
            decimal levemente = resultado2 * 1.375m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {levemente} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {levemente} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else if (opcao2 == 3 && genero == 'F')
        {
            decimal ativo = resultado2 * 1.55m;
            Console.WriteLine("========================================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Seu corpo gasta {ativo} Kcal/dia");
            Console.WriteLine($"Você precisa consumir {ativo} Kcal/dia");
            Console.WriteLine($"E é recomendado que você beba de {peso * 35m} ml a {peso * 40m} ml de aguá/dia");
            Console.WriteLine("========================================");
        }
        else
        {
            Console.WriteLine("Opção invalida");
        }
    }
}