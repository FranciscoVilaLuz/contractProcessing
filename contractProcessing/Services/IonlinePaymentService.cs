namespace ContractProcessing.Services {
    interface IonlinePaymentService {

        double PaymentFee(double amount);
        double Interest ( double amount, int months);

    }
}
