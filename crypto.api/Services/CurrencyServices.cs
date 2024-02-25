using crypto.domain.contracts;
using crypto.domain.entities;
using System;

namespace crypto.api.Services
{
    public class CurrencyServices
    {
        private readonly ICurrencyRepository CurrencyRepository;

        public CurrencyServices(ICurrencyRepository currencyRepository)
        {
         this.CurrencyRepository   = currencyRepository;
        }

        public async Task<List<CurrencyEntity>> GetCurrencies(int start, int limit)
        {
            var response = await CurrencyRepository.GetCurrencies(start, limit);

            return response;
        }

        public async Task<List<CurrencyEntity>> GetCurrency(string id)
        {
            var response = await CurrencyRepository.GetCurrency(id);

            return response;
        }

    }
}
