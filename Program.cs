using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVerifica4
{
    internal class Program
    {
        enum GiorniSettimana
        {
            Lunedi,
            Martedi,
            Mercoledi,
            Giovedi,
            Venerdi,
            Sabato,
            Domenica
        }
        enum TempoAtmosferico
        {
            Sole,
            Pioggia,
            Nuvolo,
            Neve,
            Grandine
        }

        static void Main(string[] args)
        {
            GiorniSettimana giorno = new GiorniSettimana();
            giorno = (GiorniSettimana)Enum.Parse(typeof(GiorniSettimana), Console.ReadLine(), true);
            Stampa(giorno);
            Console.ReadKey();
        }

        static void Stampa (GiorniSettimana giorno) {
            TempoAtmosferico tempo = new TempoAtmosferico();
            Random random = new Random();
            tempo = (TempoAtmosferico) random.Next(6);
            Console.WriteLine(tempo);
        }
    }
}
