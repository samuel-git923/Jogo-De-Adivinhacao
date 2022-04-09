using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class GerenciadorJogo
    {
        public GerenciadorJogo()
        {
            this.CriarPerguntas();
        }


        private List<NovaPergunta> perguntas;
        public List<NovaPergunta> Perguntas
        { 
            get { return this.perguntas; } 
        }

        public void Jogar()
        {

            // Pergunta que será exibida para o usuário
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];

            // Lógica da Resposta
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou. Dica: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabéns. Você acertou!");
            }
            else
            {
                Console.WriteLine("Sinto Muito. Você perdeu o jogo!");
                Console.Write("A resposta correta é: " + pergunta.Resposta);
            }

            Console.ReadKey();

        }
        private void CriarPerguntas()
        {
            perguntas = new List<NovaPergunta>();
            perguntas.Add(new NovaPergunta("O que significa RGB?", "Vermelho (red), Verde (green) e Azul (blue)", "Cores"));
            perguntas.Add(new NovaPergunta("Qual é a cor do céu?", "Azul", "Informe uma cor que comece com a letra A"));
            perguntas.Add(new NovaPergunta("Qual é o endereço do site de dfilitto?", "www.dfilitto.com.br", "www + o nome da pergunta + .com.br"));
            perguntas.Add(new NovaPergunta("Qual é a plataforma mais famosa para assistir filmes?", "Netflix", "O aplicativo mais utilizado do momento"));
            perguntas.Add(new NovaPergunta("Qual é a plataforma mais famosa para ouvir músicas?", "Spotify", "A primeira letra é a S"));
            perguntas.Add(new NovaPergunta("Qual é o melhor site de buscas?", "Google", "G é a primeira letra"));
            perguntas.Add(new NovaPergunta("Qual é a melhor linguagem de programação?", "C#", "Jogo da velha"));
            perguntas.Add(new NovaPergunta("Qual é o endereço do site make indie games?", "www.makeindiegames.com.br", "www + o nome da pergunta + .com.br"));
            perguntas.Add(new NovaPergunta("Qual é o melhor site para compras online", "Amazon", "Uma dos melhores sites que começa com a letra A"));
            perguntas.Add(new NovaPergunta("Qual é a capital do Brasil", "Brasília", "Começa com a letra B e a palavra se assemelha com Brasil"));
        }
    }
}
