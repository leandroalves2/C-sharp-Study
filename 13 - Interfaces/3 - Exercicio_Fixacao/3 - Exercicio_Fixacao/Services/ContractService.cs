using System;
using _3___Exercicio_Fixacao.Entities;

namespace _3___Exercicio_Fixacao.Services
{
    internal class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double parcForMonths = contract.ContractValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i + 1);
                double tot1 = parcForMonths + _onlinePaymentService.Interest(parcForMonths, i + 1);
                double tot2 = tot1 + _onlinePaymentService.PaymentFee(tot1);
                contract.AddInstallment(new Installment(date, tot2));
            }
        }
    }
}