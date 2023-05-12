using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cont 
{
    internal class Banca
    {
        private readonly string nameBank = "Banca Transilvania";
        private readonly string addressOfBank = "Strada Titu Maiorescu nr 9, Cluj";



        public Banca(string nameBank, string addressOfBank)
        {
            this.nameBank = nameBank;
            this.addressOfBank = addressOfBank;

        }
        public void TiparireText0()
        {
            Console.Write($"Contul bancar ce realizeaza la {nameBank} situata pe {addressOfBank}");
        }
    }
}
