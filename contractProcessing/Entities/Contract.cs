using System;
using System.Collections.Generic;

namespace ContractProcessing.Entities {
    internal class Contract {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installement> Installements { get; set; }


        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installements = new List<Installement>();
        }

        public void AddInstallement(Installement installement) {
            Installements.Add(installement);
        }
    }
}
