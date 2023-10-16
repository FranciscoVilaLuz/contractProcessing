using System;
using System.Globalization;
using ContractProcessing.Entities;
using ContractProcessing.Services;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine("Contract Value: ");
            double contractValue= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("INSTALLEMENTS: ");

            foreach(Installement installement  in myContract.Installements) {
                Console.WriteLine(installement);

            }

        }
    }
}