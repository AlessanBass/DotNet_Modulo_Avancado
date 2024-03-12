using System;
namespace TarefaB
{

    public class Data
    {
        private readonly int _dia;
        private readonly int _mes;
        private readonly int _ano;
        private readonly int _hora;
        private readonly int _minuto;
        private readonly int _segundo;

        public const int FORMATO_12H = 12;
        public const int FORMATO_24H = 24;

        // Construtor para data sem hora
        public Data(int dia, int mes, int ano)
        {
            _dia = dia;
            _mes = mes;
            _ano = ano;
        }

        // Construtor para data com hora
        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
        {
            if (hora < 0 || hora > 23)
            {
                throw new ArgumentException("Hora inválida. Deve estar entre 0 e 23.", nameof(hora));
            }

            _hora = hora;
            _minuto = minuto;
            _segundo = segundo;
        }

        // Propriedades somente leitura para acessar os campos privados
        public int Dia => _dia;
        public int Mes => _mes;
        public int Ano => _ano;
        public int Hora => _hora;
        public int Minuto => _minuto;
        public int Segundo => _segundo;

        // Método para imprimir a data e hora com o formato especificado
        public void imprimir(int formatoHora)
        {
            if (formatoHora != FORMATO_12H && formatoHora != FORMATO_24H)
            {
                throw new ArgumentException("Formato de hora inválido.", nameof(formatoHora));
            }

            string horaFormatada;

            if (_hora != 0 && _minuto != 0 && _segundo != 0)
            {
                if (formatoHora == FORMATO_12H)
                {
                    horaFormatada = _hora > 12 ? $"{_hora - 12}:{_minuto:D2}:{_segundo:D2} PM" : $"{_hora}:{_minuto:D2}:{_segundo:D2} AM";
                }
                else
                {
                    horaFormatada = $"{_hora:D2}:{_minuto:D2}:{_segundo:D2}";
                }
            }
            else
            {
                horaFormatada = "";
            }

            Console.WriteLine($"{_dia}/{_mes}/{_ano} {horaFormatada}");
        }

        static void Main(string[] args)
        {
            Data d1 = new Data(10, 03, 2000, 10, 30, 10);
            d1.imprimir(Data.FORMATO_12H);
            d1.imprimir(Data.FORMATO_24H);
        }
    }

}
