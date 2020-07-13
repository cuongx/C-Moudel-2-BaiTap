using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDeMo
{
    class Product
    {
        public Product()
        {
        }

        public Product(string name, string phone)
        {
            Names = name;
            numberphone = phone;
        }

        public string Names { get; set; }
        public string numberphone { get; set; }

        public override string ToString()
        {
            return " Name " + Names + "Phone " + numberphone;
        }
    }
}
