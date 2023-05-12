//Modati un cont bancar.Din contul bancar vei putea retrage si adauga bani .Scrieti o metoda ce afiseaza soldul curent
//.Soldul curent va fi initializat cu o suma curenta;

using cont;

namespace oop_bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banca folosita pentru a creea contul bancar ");

            Banca banca = new Banca("Banca Transilvania ", "Strada Titu Maiorescu nr 9,Cluj");

            banca.TiparireText0();

            Console.WriteLine("Introduceti-va datele cerute pentru a se putea creea contul bancar");

            Console.Write("Introduceti-va numele dumneavoastra de familie = ");
            string nameCustomer = Console.ReadLine();

            Console.Write("Introduceti-va prenumele dumneavoastra = ");
            string nicknameCustomer = Console.ReadLine();

            Console.Write("Introduceti-va adresa dumneavoastra scrisa pe actul de indentitate = ");
            string addressCustomer = Console.ReadLine();

            Console.Write("Introduceti-va varsta = ");
            int ageCustomer =int.Parse(Console.ReadLine());

            AccountBankCustomer accountbank = new AccountBankCustomer(nameCustomer,nicknameCustomer, addressCustomer, ageCustomer);

            Console.WriteLine("Asigurare date personale ");
            Console.WriteLine($"{accountbank.VerificareVarstaPtObtinereaUnuiCardDeDebit()}");

            accountbank.TiparesteText();

            Console.WriteLine("________________________");
            Console.Write("Operatiunea de tranzactie se realizeaza la ora = ");
            int hourTranzaction = int.Parse(Console.ReadLine());

            Console.Write("Data tranzactiei = ");
            int dateOfTranzaction = int.Parse(Console.ReadLine());

            Console.Write("Tastati ce suma doriti sa depuneti = ");
            double baniDepusi = double.Parse(Console.ReadLine());

            Console.Write("Tastati ce suma doriti sa retrageti = ");
            double baniRetrasi = double.Parse(Console.ReadLine());

            Tranzactie tranzactie = new Tranzactie(dateOfTranzaction, hourTranzaction, 500);

            tranzactie.Text();

            Console.WriteLine($" Soldul actualizat dupa depunere de {baniDepusi}de lei  in suma initiala de {tranzactie.DepunereBani(baniDepusi)} lei");

            tranzactie.Text2();

            Console.WriteLine($" Soldul actualizat dupa ce au fost retrasa suma de {baniRetrasi}de lei  din suma initiala ={tranzactie.RetragereBani(baniRetrasi)} lei");

            Console.WriteLine("________________________");
        }
    }
}