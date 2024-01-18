namespace Jogo_sem_tela.Models
{
    public class Jogo
    {
        public string Maquina()
        {
            var rand = new Random();
            Dictionary<int, string> Jogada = new Dictionary<int, string>();
            Jogada.Add(0, "Pedra");
            Jogada.Add(1, "Papel");
            Jogada.Add(2, "Tesoura");
            int resultado = rand.Next(Jogada.Count);
            return Jogada[resultado];
        }

        public void Resultado(string Jogador, string Maquina)
        {
            if(Jogador == Maquina)
            {
                Console.WriteLine($"Jogador: {Jogador}\n\tX\nMaquina: {Maquina}.\n\tEmpate!!");
            }
            else if(Jogador == "Pedra" && Maquina == "Tesoura")
            {
                Console.WriteLine($"Jogador: {Jogador}\n\tX\nMaquina {Maquina}\n\tJogador Ganhou!!");
            }
            else if(Jogador == "Tesoura" && Maquina == "Papel")
            {
                Console.WriteLine($"Jogador: {Jogador}\n\tX\nMaquina {Maquina}\n\tJogador Ganhou!!");
            }
            else if(Jogador == "Papel" && Maquina == "Pedra")
            {
                Console.WriteLine($"Jogador: {Jogador}\n\tX\nMaquina {Maquina}\n\tJogador Ganhou!!");
            }
            else
            {
                Console.WriteLine($"Jogador: {Jogador}\n\tX\nMaquina: {Maquina}\n\tMaquina Ganhou!!");
            }
        }
    }
}