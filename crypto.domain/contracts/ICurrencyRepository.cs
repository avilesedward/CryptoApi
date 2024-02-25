using crypto.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto.domain.contracts
{
    public interface ICurrencyRepository
    {
        public Task<List<CurrencyEntity>> GetCurrencies(int start, int limit);

        public Task<List<CurrencyEntity>> GetCurrency(string id);
    }
}
