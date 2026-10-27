namespace CalculadoraDeCalorias;

public class Menu
{

    Calculadora calculadora = new Calculadora();
    public void ExibirMenu()
    {
        bool Continuar = true;
        int opcao = 0;

        while(Continuar)
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA DE CALORIAS");
            Console.WriteLine("======================");
            Console.WriteLine("1- Perder Peso");
            Console.WriteLine("2- Ganhar Peso");
            Console.WriteLine("3- Manter o Peso");
            Console.WriteLine("4- Sair");
            Console.WriteLine("======================");

            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Por favor, digite apenas números (1, 2, 3 ou 4).");
                calculadora.AguardarEnter();
            }
            else if (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4)
            {
                Console.WriteLine("Opção inválida! Escolha um número entre 1 e 4.");
                calculadora.AguardarEnter();
            }


            switch(opcao)
            {
                case 1:
                calculadora.PerderPeso();
                calculadora.AguardarEnter();
                break;

                case 2:
                calculadora.GanharPeso();
                calculadora.AguardarEnter();
                break;

                case 3:
                calculadora.ManterPeso();
                calculadora.AguardarEnter();
                break;

                case 4:
                Continuar = false;
                Console.WriteLine("Saindo...");
                break;

                default:
                Console.WriteLine("Opção invalida!");
                break;
            }
        }
    }

}