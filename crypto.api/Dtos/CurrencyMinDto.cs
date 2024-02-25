namespace crypto.api.Dtos
{
    public class CurrencyMinDto
    {
        //ID of cryptocurrency
        public string id { get; set; }
        //Cryptocurrency Ticker symbol
        public string symbol { get; set; }
        //Name slug
        public string nameid { get; set; }
        //Full name of crypto coin
        public string name { get; set; }
        //Price in USD currency
        public string price_usd { get; set; }
        //Price change in percent for last 24h
        public string percent_change_24h { get; set; }

    }
}
