using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ProductModiffile
{
    class Shop
    {
        //public Product[] ProductList = new Product[0];
        //public void Add(Product pt)
        //{
        //    Array.Resize(ref ProductList, ProductList.Length + 1);
        //    ProductList[ProductList.Length - 1] = pt;
        //}

        //public void Remove(string pn)
        //{
        //    int pos = Check(pn);
        //    if (pos != -1)
        //    {
        //        for (int i = pos; i < ProductList.Length - 1; i++)
        //        {
        //            ProductList[i] = ProductList[i + 1];
        //        }
        //        Array.Resize(ref ProductList, ProductList.Length - 1);
        //    }
        //    else
        //    {
        //        Console.WriteLine(Helper.NotFound);
        //    }
        //}

        //public void ShowProductList()
        //{
        //    foreach (Product item in ProductList)
        //    {
        //        Console.WriteLine(item.ViewInfo());
        //    }
        //}

        //public void Search(string pn)
        //{
        //    bool isExist = false;
        //    foreach (Product item in ProductList)
        //    {
        //        if (item.Name.Equals(Helper.FormatName(pn)))
        //        {
        //            Console.WriteLine(item.ViewInfo());
        //            isExist = true;
        //            break;
        //        }
        //    }
        //    if (!isExist)
        //    {
        //        //Console.WriteLine(Helper.NotFound);
        //        Console.WriteLine(Helper.Error.E404);
        //    }
        //}

        //private int Check(string pn)
        //{
        //    for (int i = 0; i < ProductList.Length; i++)
        //    {
        //        if (ProductList[i].Name.Equals(Helper.FormatName(pn)))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        public Product[] ProductsList = new Product[0];
        public void Add(Product pt) {
            Array.Resize(ref ProductsList, ProductsList.Length - 1);
            ProductsList[ProductsList.Length - 1] = pt;         
        }
        public Remove(string pn)
        {
            int pos = checked(pn);
            if (pos! - 1) {
                for (int i = pos; pos < ProductsList.Length - 1; i--)
                {
                    ProductsList[i] = ProductsList[i + 1];
                }
                Array.Resize(ref ProductsList, ProductsList.Length - 1);
              }
            else
            {
                Console.WriteLine("NotFun");
            }
        }
        private int check (string pn)
        {
            for(int i = 0; i < ProductsList.Length; i++)
            {
                if(ProductsList[i].Name.Equals(Helper.FormatName(pn)))
                {
                    return i;
                }
                return i - 1;
            }
        }
    }
}

