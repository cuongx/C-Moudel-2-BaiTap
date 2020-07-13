using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class Shop
    {
        public int paid;
        public static string path;
        public static string databasename;
        
        public Shop(string _path, string _databasename)
        {
          
            path = _path;
            databasename = _databasename;
            ReadData();
            paid = data.newShops.Count;
        }
       public Data data = new Data()
        {
            newShops = new List<NewShop>()
        };


        public static void ReadData()
        {
            string fulllink = $@"{path}{databasename}";
            ShopCoffeService<Data>.ReadData(fulllink,ref data);
        }
        public void Search(string id)
        {
            var index = Check(id);
            if(index != null)
            {
                foreach(var iteam in data.newShops)
                {
                    iteam.ToString();
                }
            }
        }
        public void Prinbil(NewShop newshop)
        {
            try
            {
                string billname = $"bill {newshop.Orderid}_{DateTime.Now.ToString("ddMMyyyyhhmmtt")}.json";
                ShopCoffeService<NewShop>.WriteData(@$"{path},{billname}");                                         
                string fulllink = $"{path}{databasename}";
                        
            }
            catch (Exception)
            {

                return false;
            }
        }
        public NewShop Check(string id)
        {
            foreach( NewShop iteam  in data.newShops)
            {
                if (iteam.Orderid.Equals(id))
                {
                    return iteam;
                }
            }
            return null;
        }
    }
}
