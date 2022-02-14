using System;

namespace Avaliação1_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------------------");
                Console.WriteLine("VERIFICADOR DE TRIÂNGULOS");
                Console.WriteLine("--------------------------");
                Console.WriteLine("           /-\\");
                Console.WriteLine("          /---\\");
                Console.WriteLine("         /-----\\");
                Console.WriteLine("        /-------\\");
                Console.WriteLine("       /---------\\");
                Console.WriteLine("      /-----------\\");
                Console.WriteLine("     /-------------\\");
                Console.WriteLine("    /_______________\\");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("APERTE A TECLA ENTER PARA COMEÇAR");
                Console.WriteLine("-----------------------------------");

                
                Console.ForegroundColor= ConsoleColor.White;

                Console.ReadLine();
                Console.Clear();

            do
            {

                Console.WriteLine("Digite o valor de X do triângulo");
                 int x = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor de Y do triângulo");
                int y = System.Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor de Z do triângulo");
                int z = System.Convert.ToInt32(Console.ReadLine());


                Console.Clear();

                if (x > y+z || y >z + x || z> x+y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Triângulo Inválido");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if(x ==y && x == z && y==z)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O triângulo é equilátero");
                    }else if (x == y || x==z || z == y) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O triângulo é isósceles");
                    

                    }else if (x != y && x != z && y != z)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O triângulo é escaleno");
                    }

                }
                
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Deseja verificar um triângulo novamente?(s/n)");
                    opcao = Console.ReadLine();

                    if (opcao != "s" && opcao != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando Inválido, tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                    }
                } while (opcao != "s" && opcao != "n");
                Console.Clear();
            } while (opcao == "s");
        }
    }
}
