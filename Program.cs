using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_01
{
    class Ember
    {
        public string nev;
        public int eletkor;
        public string bemutatkozas()
        {
            string s= $"{nev} vagyok {eletkor} éves";
            return s;
            //Console.WriteLine("{0} vagyok {1} éves", nev, eletkor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ember pista = new Ember();
            Ember eva = new Ember();
            eva.eletkor = 18;
            eva.nev = "Nagy Eva";
            pista.eletkor = 26;
            pista.eletkor++;
            pista.nev = "Tóth István";       
            Console.WriteLine(pista.bemutatkozas());
            Console.WriteLine(eva.bemutatkozas());
            Console.ReadKey();
        }
    }
}
