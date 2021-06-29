using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        public static int cont;
        const int tamanho = 81;
        public static IdentificaMinas[] posiValidas = new IdentificaMinas[tamanho];
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            IdentificaMinas minasV;
            int i = 0;
            while (campoMinado.JogoStatus ==0) 
             {
                 Console.WriteLine("Insira a linha onde voce quer fazer o seu movimento");
                 int line = int.Parse(Console.ReadLine());
                 Console.WriteLine("Insira a Coluna onde voce quer fazer o seu movimento");
                 int column = int.Parse(Console.ReadLine());

                campoMinado.Abrir(line, column);
                verificaTabuleiro(line, column);

                if (campoMinado.JogoStatus == 0)
                 {
                    Console.WriteLine("Proxima jogada");
                    minasV = posiValidas[i];
                    campoMinado.Abrir(minasV.Linha, minasV.Coluna);
                    i++;
                    Console.WriteLine(campoMinado.Tabuleiro);

                }
                 else if (campoMinado.JogoStatus == 1)
                 {
                     Console.WriteLine("Parabens voce consguiu passou com sucesso pelo campo minado");
                     Console.WriteLine(campoMinado.Tabuleiro);
                 }
                 else 
                 {
                     Console.WriteLine("Game Over, voce encontrou uma bonba, mas não desanime da proxima voce consegue");
                     Console.WriteLine(campoMinado.Tabuleiro);
                 }
             }
            
            Console.ReadKey();

        }

        static void verificaTabuleiro(int line ,int column) 
        {
            var campoMinado = new CampoMinado();
            IdentificaMinas minasV;

            if (campoMinado.JogoStatus == 0)
            {
                minasV = new IdentificaMinas(line + 1, column);
                posiValidas[cont] = minasV;
                cont++;
            }
            else if (campoMinado.JogoStatus == 2)
            {
                minasV = new IdentificaMinas(line, column + 1);
                posiValidas[cont] = minasV;
                cont++;
            }
        }
    }
}
