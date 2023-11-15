using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    internal class Liftezgetesek
    {
        DateTime idopont;
        int sorszam;
        int indulo;
        int erkezo;

        public Liftezgetesek(DateTime idopont, int sorszam, int indulo, int erkezo)
        {
            this.idopont = idopont;
            this.sorszam = sorszam;
            this.indulo = indulo;
            this.erkezo = erkezo;
        }

        public DateTime Idopont { get { return idopont; } }
        public int Sorszam { get { return sorszam; } }
        public int Indulo { get {  return indulo; } }
        public int Erkezo { get {  return erkezo; } }
    }
}
