using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BaiTap2
{
    static  class ShopCoffeService <T>
    {

       public static void ReadData(string fullpath,T data)
        {
            using (StreamReader sw = File.OpenText(fullpath))
            {
                var obj = sw.ReadToEnd();
                data = JsonConvert.DeserializeObject<T>(obj);
            }
        }

        public static void WriteData(string fullpath,T data)
        {
            using(StreamWriter sb = File.CreateText(fullpath))
            {
                var dete = JsonConvert.SerializeObject(data);
                sb.WriteLine();
            }
        }
    }
}
