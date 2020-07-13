using System;
using System.Collections;
using System.Collections.Generic;

namespace Hastable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một Hashtable đơn giản với 3 phần tử
            Hashtable hash = new Hashtable();
            hash.Add("K", "Kteam");
            hash.Add("H", "HowKteam");
            hash.Add("FE", "Free Education");

            /* 
             * Duyệt qua các phần tử trong Hashtable.
 * Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
             * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
             */
            foreach (DictionaryEntry item in hash)
            {

                Console.WriteLine(item.Key + "\t" + item.Value);

            }


            //in ra màn hình giá trị Value trong 1 Key không tồn tại.
            Console.WriteLine(hash["VT"]);

            //để chắc chắn là null ta thử kiểm tra bằng điều kiện if.
            //if (hash["vt"] == null)
            //    {
            //    Console.WriteLine("key 'vt' is not exists");
            //        }

                    // Thử in ra số phần tử ban đầu của Hashtable
            //        Console.WriteLine("\nCount: " + hash.Count);

            //foreach (DictionaryEntry item in hash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            // thực hiện gán giá trị cho 1 Key không tồn tại.
            hash["Kt"] = "Kter";
            hash["Helo"] = "Indez";
            // thực hiện in lại số phần tử của Hashtable để thấy sự thay đổi.
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

        }
    }
}
