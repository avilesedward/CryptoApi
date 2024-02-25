namespace crypto.api.Dtos
{
    public class CurrencyDto
    {
        //ID of cryptocurrency
        public string id { get; set; }
        //Cryptocurrency Ticker symbol
        public string symbol { get; set; }
        //Name slug
        public string nameid { get; set; }
        //Full name of crypto coin
        public string name { get; set; }
        //Rank by marketcap
        public string rank { get; set; }
        //Price in USD currency
        public string price_usd { get; set; }
        //Price change in percent for last 24h
        public string percent_change_24h { get; set; }
        //Price change in percent for last 1h
        public string percent_change_1h { get; set; }
        //Price change in percent for last 7 days
        public string percent_change_7d { get; set; }
        //How much coin costs in BTC
        public string price_btc { get; set; }
        //Coin marketcap in USD
        public string market_cap_usd { get; set; }
        //Trading volume of coin for last 24h in USD
        public string volume24 { get; set; }
        //How many coins has been traded
        public string volume24a { get; set; }
        //Circulating Supply
        public string csupply { get; set; }
        //Total Supply
        public string tsupply { get; set; }
        //Maximum Supply
        public string msupply { get; set; }
    }
}
