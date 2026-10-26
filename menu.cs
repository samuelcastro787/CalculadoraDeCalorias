namespace CalculadoraDeCalorias;

public class Menu
{

    Calculadora calculadora = new Calculadora();
    public void ExibirMenu()
    {
        bool Continuar = true;

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
            int opcao = int.Parse(Console.ReadLine());


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