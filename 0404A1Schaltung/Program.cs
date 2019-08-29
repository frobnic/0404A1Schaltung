using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404A1Schaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            double R=0; // Widerstand in Ohm
            double S=0; // Eingangsspannung in Volt
            double C=0; // Kapazität in Farad
            double t; // Zeit in microsekunden
            double v; // Hysteresespannung
            double i; // increment in microsekunden
            Boolean ok = true; // Flag für Eingabefehler

            Console.Write("R: ");
            ok = ok && double.TryParse(Console.ReadLine(), out R);

            Console.Write("C: ");
            ok = ok && double.TryParse(Console.ReadLine(), out C);

            Console.Write("S: ");
            ok = ok && double.TryParse(Console.ReadLine(), out S);

            if (!ok)
                Console.WriteLine("Eingabefehler!");
            else
            {
                // Farad in mikrofarad umrechnen
                C = C / 1000;
                C = C / 1000;

                t = 0;        // Zeit
                i = 0.00001; // Increment 
                do
                {
                    v = S * (1 - Math.Pow(Math.E, -t / (R*C) ));
                    t = t + i;
                    Console.WriteLine("t {0,8F2}  v {1}",t ,v);
                } while ( v < (S * 0.99));
            }

        }
    }
}
