using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using crypto.domain.contracts;
using crypto.domain.entities;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace crypto.infraestructure.repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IConfiguration _configuration;
        public CurrencyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public async Task<List<CurrencyEntity>> GetCurrencies(int start, int limit)
        {
            Root ResponseObject = new Root();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url = _configuration["CoinloreUrl"] + @"tickers/?start=" + start.ToString() + "&limit=" + limit.ToString();
                    var response = await client.GetAsync(url);
                   
                    if (response != null && response.StatusCode == HttpStatusCode.OK)
                    {
                        ResponseObject = await response.Content.ReadFromJsonAsync<Root>();
                    }
                }
                return ResponseObject.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CurrencyEntity>> GetCurrency(string id)
        {
            List<CurrencyEntity> ResponseObject = new List<CurrencyEntity>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url = _configuration["CoinloreUrl"] + @"ticker/?id=" + id;
                    var response = await client.GetAsync(url);
                    if (response != null && response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        ResponseObject = await response.Content.ReadFromJsonAsync<List<CurrencyEntity>>();
                    }
                }
                return ResponseObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
