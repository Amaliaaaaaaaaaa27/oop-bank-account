using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace oop_bank_account
{
    internal class Tranzactie
    {
        private readonly int dateOfTranzaction;
        private readonly int hourTranzaction;
        private readonly double initialSold = 500;

        public Tranzactie(int dateOfTranzaction, int hourTranzaction,double  initialSold)
        {
            this.dateOfTranzaction = dateOfTranzaction;
            this.hourTranzaction = hourTranzaction;
            this.initialSold = initialSold;
        }
       
        public double DepunereBani(double baniDepusi)
        {
            if (baniDepusi <= 10)
            {
                Console.WriteLine("Suma minima de a depune bani incepe de la 10 lei ");
            }

            double  SoldActualizat = initialSold + baniDepusi;

            return SoldActualizat;
        }
        public void Text()
        {
            Console.WriteLine($"Operatiunea de depunere s a desfarsurat la ora {hourTranzaction} pe data de {dateOfTranzaction}");
        }
        public double RetragereBani(double baniRetrasi)
        { 
            if( baniRetrasi > initialSold)
            {
                Console.WriteLine("Fonduri insuficiente");
            }

            double SoldActualizat = initialSold - baniRetrasi;

            return SoldActualizat;
        }
        public void Text2()
        {
            Console.WriteLine($"Operatiunea de retragere s a desfarsurat la ora {hourTranzaction} pe data de {dateOfTranzaction}");
        }
    }
}

