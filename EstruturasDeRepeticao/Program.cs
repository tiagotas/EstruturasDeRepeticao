using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Começou o Programa");

            // for = Para
            // while = Enquanto
            // do while = Faça Enquanto
            // foreach = Para Cada

            //    Controle   // Parada     // Incremento
            for(  int i=0;       i<5;       i++ )
            {
                Console.WriteLine("Valor da variável i = {0} ", i);
            }

            Console.WriteLine("Saiu do Looping (Estrutura de Repetição) For");


            // Variável de Controle
            int x = 0;

            //    Critério de Parada     
            while (x < 5)
            {
                Console.WriteLine("O valor de x é {0} ", x);

                x++; // x = x + 1;
            }


            Console.Clear(); // RETIRAR PARA VER TODO O CÓDIGO FUNCIONANDO.


            //string senha = "123";


            // Variável de Controle
            string quer_sair = "N";

            // Contador de repetições
            int rep = 0;

            while(quer_sair != "S")
            {
                rep++; // incremento => rep = rep + 1
                
                Console.WriteLine("Você está preso no Looping.");
                Console.WriteLine("Quer sair? S = sim");

                quer_sair = Console.ReadLine().ToUpper();

                if (rep == 3)
                    break; // Para a execução do lopping.
            }

            Console.WriteLine("Você saiu do Looping.");
            Console.WriteLine("Você repetiu {0} vezes. ", rep);



            Console.Clear(); // RETIRAR PARA VER TODO O CÓDIGO FUNCIONANDO.




            int y = 2;

            do
            {
                Console.WriteLine("O valor de y é {0} ", y);

                y++;

            } while (y < 5);

            Console.WriteLine("Saiu do Do ... While com Y valendo {0}", y);


            Console.ReadKey();           
        }
    }
}
