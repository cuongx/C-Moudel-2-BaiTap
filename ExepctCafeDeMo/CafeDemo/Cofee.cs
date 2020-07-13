using CafeDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo
{
    class Cofee
    {
        public static string path = @$"D:\Moudel 2\ExepctCafeDeMo\CafeDemo\Data\";
        public static string fillname ="Data.json";
        public static CofffeeService cofffeeService = new CofffeeService(path, fillname);
    }
}
