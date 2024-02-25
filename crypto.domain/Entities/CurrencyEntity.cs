using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto.domain.entities
{

    public class CurrencyEntity
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
        public int rank { get; set; }
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
        public double volume24 { get; set; }
        //How many coins has been traded
        public double volume24a { get; set; }
        //Circulating Supply
        public string csupply { get; set; }
        //Total Supply
        public string tsupply { get; set; }
        //Maximum Supply
        public string msupply { get; set; }
    }
    public class Info
    {
        public int coins_num { get; set; }
        public int time { get; set; }
    }

    public class Root
    {
        public Root()
        {
            data = new List<CurrencyEntity>();
            info = new Info();
        }
        public List<CurrencyEntity> data { get; set; }
        public Info info { get; set; }
    }

}
