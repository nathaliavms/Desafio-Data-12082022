using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    class TempoDoJogo
    {
        public int HoraInicial { get; set; }
        public int MinutoInicial { get; set; }
        public int HoraFinal { get; set; }
        public int MinutoFinal { get; set; }
        public int ResultadoHoras { get; set; }
        public int ResultadoMinutos { get; set; }

        public TempoDoJogo(int horainicial, int minutoinicial, int horafinal, int minutofinal)
        {
            HoraInicial = horainicial;
            MinutoInicial = minutoinicial;
            HoraFinal = horafinal;
            MinutoFinal = minutofinal;
           
        }

        public int CalcularHoraDoJogo()
        {
            if ((HoraFinal > HoraInicial && MinutoFinal >= MinutoInicial) || 
               (HoraFinal >= HoraInicial && MinutoFinal > MinutoInicial))
            {
                ResultadoHoras = HoraFinal - HoraInicial;
                ResultadoMinutos = MinutoFinal - MinutoInicial;
                
            }
            else if (HoraFinal == HoraInicial && MinutoFinal == MinutoInicial)
            {
                ResultadoHoras = 24;
                ResultadoMinutos = 0;
            }
            else if (HoraFinal == HoraInicial && MinutoFinal < MinutoInicial)
            {
                ResultadoHoras = 23;
                ResultadoMinutos = MinutoFinal + (60 - MinutoInicial);
            }
            else if (HoraFinal > HoraInicial && MinutoFinal < MinutoInicial)
            {
                ResultadoHoras = HoraFinal - HoraInicial - 1;
                ResultadoMinutos = MinutoFinal + (60 - MinutoInicial);
            }
            else if (HoraFinal < HoraInicial && MinutoFinal < MinutoInicial)
            {
                ResultadoHoras = HoraFinal + (24 - HoraInicial) - 1;
                ResultadoMinutos = MinutoFinal + (60 - MinutoInicial);
            }
            else if (HoraFinal < HoraInicial && MinutoFinal >= MinutoInicial)
            {
                ResultadoHoras = HoraFinal + (24 - HoraInicial);
                ResultadoMinutos = MinutoFinal - MinutoInicial;
            }

            return ResultadoHoras;
        }
        
        public int CalcularMinutosDoJogo()
        { 
            return ResultadoMinutos;
        }
    }
}
