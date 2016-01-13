





//Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.Tee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä)
//kuluvan bensan määrän sekä bensaan menevän rahan määrän.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
           double matka;  
        
            Console.Write("anna matkasi pituus");
            matka = int.Parse(Console.ReadLine());
            double kulutus= 7.02;
            double bensa = matka / 100 * kulutus;
            double hinta= bensa*kulutus;
         double   bensanhinta = 1.595;
            Console.WriteLine("bensan kulutus{0:F2} litraa. ",bensa);
            Console.WriteLine("hinta on {0:F2} euroa. ", kulutus*bensanhinta);


        }
    }
}
