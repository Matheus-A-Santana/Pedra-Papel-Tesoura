using Jogo_sem_tela.Models;

namespace Jogo_sem_tela;

class Program
{
    static void Main(string[] args)
    {
        Jogo jogo = new Jogo();
        bool game = true;
        while(game)
        {
            Console.WriteLine("\tJogo Pedra Papel e Tesoura\n" +
                                "[1] - Pedra\n" +
                                "[2] - Papel\n" +
                                "[3] - Tesoura\n" +
                                "[0] - Sair");
            
            switch(Convert.ToInt64(Console.ReadLine()))
            {
                case 0:
                    game = false;
                    break;
                case 1:
                    jogo.Resultado("Pedra", jogo.Maquina());
                    break;
                case 2:
                    jogo.Resultado("Papel", jogo.Maquina());
                    break;
                case 3:
                    jogo.Resultado("Tesoura", jogo.Maquina());
                    break;
                default:
                    Console.WriteLine("Opção inválida!\nPor favor selecione uma Opção válida");
                    break;
            }
            Console.WriteLine("Aperte Qualquer tecla...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
