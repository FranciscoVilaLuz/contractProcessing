using System;
using ContractProcessing.Services;

namespace ContractProcessing.Services {
    internal class PaypalService : IonlinePaymentService {

        private const double FreePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months) {
            return amount * MonthlyInterest * months;
        }
        public double PaymentFee (double amount) {

            return amount * FreePercentage;
        }

    }
}
