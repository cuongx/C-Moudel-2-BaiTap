using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace CafeDemo.Services
{
    public static class ReadWriteService<T> where T : class
    {
        public static T ReadData(string fullpath)
        {
            try
            {
                T data;
                using (StreamReader sr = File.OpenText(fullpath))
                {
                    var obj = sr.ReadToEnd();
                    data = JsonConvert.DeserializeObject<T>(obj);
                }
                return data;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static bool WriteData(string fullpath, T data)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    var dete = JsonConvert.SerializeObject(data);
                    sw.WriteLine(dete);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }

}
