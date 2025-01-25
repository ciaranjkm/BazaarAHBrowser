using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using System.Numerics;

namespace BazaarAHBrowser
{
    public class Hypixel_api
    {
        private static string BASE_URL = "https://api.hypixel.net/";
        private static readonly HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri(BASE_URL)
        };

        private ItemInformation? nameMappings;
        private Dictionary<string, BazaarProduct> bazaarItems;

        //constructor loads the name mappings into memory for quick access
        public Hypixel_api()
        {
            loadInternalNameMappings();
            bazaarItems = new Dictionary<string, BazaarProduct>();
        }

        //LOAD LOCAL FILES 

        //get name mappings from local json file [update to grab new from github on startup]
        private void loadInternalNameMappings()
        {
            string jsonString = File.ReadAllText("InternalNameMappings.json");
            nameMappings = JsonConvert.DeserializeObject<ItemInformation>(jsonString);
        }

        //API CALLS

        //loads bazaar data api
        public async Task<Dictionary<string, BazaarProduct>> loadBazaarDataAPI()
        {
            //https://api.hypixel.net/v2/skyblock/bazaar
            string request = "v2/skyblock/bazaar"; //sets the request to send

            using HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(request); 

            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync(); //get the json response as a string

            BazaarRequestData? items = JsonConvert.DeserializeObject<BazaarRequestData>(jsonResponse); //deserialise the string into BazaarItems
            
            if (items != null)
            {
                foreach(KeyValuePair<string, BazaarProduct> product in items.products)
                {
                    bazaarItems.Add(convertItemIdToItemName(product.Key), product.Value);
                }

                return bazaarItems;
            }

            return null;
        }

        public List<quick_statusItem> returnQuickStatusItems()
        {
            List<quick_statusItem> qsItems = new List<quick_statusItem>();
            foreach(KeyValuePair<string, BazaarProduct> b in bazaarItems)
            {
                qsItems.Add(b.Value.quick_status);
            }

            return qsItems;
        }

        //UTILITY FUNCTIONS

        //converts an itemid to its name in game and returns it, if no name found then return null;
        public string? convertItemIdToItemName(string itemId)
        {
            string? name = null;
            try
            {
                name = nameMappings.items[itemId].name; //find name in nameMappings dictionary
            }
            catch //if item name is not found throw an error and catch
            {
                if (itemId.StartsWith("ENCHANTMENT"))
                {
                    name = itemId.Replace("ENCHANTMENT_", "");
                    name = name.Replace("_", " ");
                }
                else
                {
                    name = itemId.Replace("_", " ");
                }
            }

            return name;
        }
    }

    //JSON CLASSES

    //bazaar items class
    public class BazaarRequestData
    {
        public bool success;
        public long lastUpdated;
        public Dictionary<string, BazaarProduct> products;
    }
    public class BazaarProduct
    {
        public string product_id;
        public sell_summaryItem[] sell_summary;
        public buy_summaryItem[] buy_Summary;
        public quick_statusItem quick_status;
    }
    public class sell_summaryItem
    {
        public int amount;
        public float pricePerUnit;
        public int orders;
    }
    public class buy_summaryItem
    {
        public int amount;
        public float pricePerUnit;
        public int orders;
    }
    public class quick_statusItem
    {
        public string productId { get; set; } //0, 1, 3, 5, 7
        public float sellPrice { get; set; }
        public float sellVolume { get; set; }
        public BigInteger sellMovingWeek { get; set; }
        public float sellOrders { get; set; }
        public float buyPrice { get; set; }
        public float buyVolume { get; set; }
        public BigInteger buyMovingWeek { get; set; }
        public float buyOrders { get; set; }
    }

    //item id to item name class
    public class ItemInformation
    {
        public Dictionary<string, ItemData> items;
    }
    public class ItemData
    {
        public string name;
        public string base_rarity;
    }
}
