using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 4 Números Inteiros: ");
            string[] s = Console.ReadLine().Split(' ');

            int horainicial = int.Parse(s[0]);
            int minutoinicial = int.Parse(s[1]);
            int horafinal = int.Parse(s[2]);
            int minutofinal = int.Parse(s[3]);
            

            TempoDoJogo duracao = new TempoDoJogo(horainicial, minutoinicial, horafinal, minutofinal);

            Console.WriteLine("O JOGO DUROU " 
                + duracao.CalcularHoraDoJogo() 
                + " HORA(S) E "
                + duracao.CalcularMinutosDoJogo()
                + " MINUTO(S)");
        }
    }
}
