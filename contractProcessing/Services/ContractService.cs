using ContractProcessing.Entities;
using System;

namespace ContractProcessing.Services {
    internal class ContractService {

        private IonlinePaymentService _onlinePaymentService;

        public ContractService(IonlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;

        }
        public void ProcessContract (Contract contract, int months) {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double upDateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = upDateQuota + _onlinePaymentService.PaymentFee(upDateQuota);
                contract.AddInstallement(new Installement(date, fullQuota));

            }
        }
    }

}