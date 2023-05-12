using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace oop_bank_account
{
    class AccountBankCustomer
    {
        private readonly string nameCustomer;
        private readonly string nicknameCustomer;
        private readonly string addressOfCustomer;

        private readonly int ageCustomer;

        public AccountBankCustomer(string nameCustomer, string nicknameCustomer, string addressOfCustomer, int ageCustomer)
        {
            this.nameCustomer = nameCustomer;
            this.nicknameCustomer = nicknameCustomer;
            this.addressOfCustomer = addressOfCustomer;
            this.ageCustomer = ageCustomer;
        }
        public void TiparesteText()
        {
            Console.WriteLine($"Contul bancar este pe numele {nameCustomer} {nicknameCustomer} , cu varsta de {ageCustomer} si cu adresa {addressOfCustomer}");
        }
        public int VerificareVarstaPtObtinereaUnuiCardDeDebit()
        {
            if (ageCustomer < 14)
            {
                Console.Write("Operatiunea nu se poate realiza astfel nu mai completati formularul pt creeare cont de debit");
            }
            else if (ageCustomer == 15 || ageCustomer == 16 || ageCustomer == 17)
            {
                Console.Write("Se poate creea contul bancar doar insotit de un parinte ");
            }
            else
            {
                Console.Write("Contul se poate realiza fara insotitor");
            }

            return ageCustomer;
        }
    }
}
