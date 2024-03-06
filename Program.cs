using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Seja Bem-vindo a minha Calculadora!!!");

            Console.WriteLine("");

            Console.WriteLine("Qual operação deseja fazer?");

            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Digite sua opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                case 5 : System.Environment.Exit(0); break;
                default : Erro(); break;

            }
        }
        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}" );
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}" );
            Console.ReadKey();
            Menu();
        } 
        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}" );
            Console.ReadKey();
            Menu();
        }
        static void Erro()
        {
            Console.Clear();
            Console.WriteLine("Nenhuma das opções foi selecionada!!!");

            Console.WriteLine("");

            Console.WriteLine("Deseja voltar ao menu?");

            Console.WriteLine("-------------------------");

            Console.WriteLine("1 - Sim!");
            Console.WriteLine("2 - Não!");
            
            Console.WriteLine("");

            Console.WriteLine("Digite sua opção: ");
            float selc = float.Parse(Console.ReadLine());

            switch (selc)
            {
                case 1 : Menu(); break;
                case 2 : Environment.Exit(0); break;
                default : Menu(); break;
            }



        }
   }
}