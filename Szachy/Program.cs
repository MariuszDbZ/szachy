using System;
using Szachy.Atrybuty;
using Szachy.Figury;

namespace Szachy
{
    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// main.
        /// </summary>
        /// <param name="args">
        /// args.
        /// </param>
        private static void Main(string[] args)
        {
            var szachownica = new Szachownica();
            var cel = new Pozycja(2, 1);
            var figura = szachownica.PobierzFigure(cel);

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); // Ta sama metoda ToString zwraca co innego w zaleznosci do czego rzutujemy.
            Console.WriteLine(((Pionek)figura).ToString("moj")); // Metode nadpisana przez 'new' mozna przeciazac.

            szachownica.PrzestawFigure(new Pozycja(1, 1), cel);
        }
    }
}