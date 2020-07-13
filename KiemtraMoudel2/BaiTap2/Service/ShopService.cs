using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2.Service
{
    class ShopService
    {
        public Data data;
        private string path;
        private string databasename;
        private string fullpath => @$"{path}\{databasename}";
        public ShopService(string _path, string _databasename)
        {
            data = new Data()
            {
                newShops = new List<NewShop>()
            };
            path = _path;
            databasename = _databasename;
            ReadWriteService<Data>.ReadData(fullpath, data);
        }
}
