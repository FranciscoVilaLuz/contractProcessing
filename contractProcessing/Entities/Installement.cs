using System.Globalization;

namespace ContractProcessing.Entities {
    internal class Installement {

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installement(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + "-  "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
