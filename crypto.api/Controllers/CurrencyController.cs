using AutoMapper;
using crypto.api.Dtos;
using crypto.api.Services;
using crypto.domain.entities;
using Microsoft.AspNetCore.Mvc;

namespace crypto.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly CurrencyServices _currencyServices;
        public CurrencyController(CurrencyServices currencyServices, IMapper mapper)
        {
            _mapper = mapper;
            this._currencyServices = currencyServices;
        }

        [HttpGet("GetCurrencies")]
        public async Task<IActionResult> GetCurrencies(int start = 0, int limit = 10)
        {
            try
            {
                start = ValidateStart(start);
                limit = ValidateLimit(limit);

                var Lista = new List<CurrencyMinDto>();
                var response = await _currencyServices.GetCurrencies(start, limit);

                foreach (var currency in response)
                {
                    Lista.Add(_mapper.Map<CurrencyMinDto>(currency));
                }
                return Ok(Lista);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("GetCurrency")]
        public async Task<IActionResult> GetCurrency(string id)
        {
            try
            {
                var currency = new CurrencyDto();
                var response = await _currencyServices.GetCurrency(id);

                if (response.Count > 0)
                {
                    currency = _mapper.Map<CurrencyDto>(response[0]);
                    return Ok(currency);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        #region validators
        private int ValidateStart(int start)
        {
            if (start < 0) return 0;
            else return start;
        }

        private int ValidateLimit(int limit)
        {
            if (limit > 100) return 100;
            if (limit <= 0) return 10;
            return limit;
        }
        #endregion
    }
}
