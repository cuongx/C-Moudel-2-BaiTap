using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BaiTapDeMo
{
   abstract class Phone
    {

        public abstract void InsertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
    }
   class PhoneBook : Phone
    {

        public ArrayList PhoneList = new ArrayList();
        
    public PhoneBook()
        {
            PhoneList = new ArrayList()
            {
                new Product("thuong","123"+"\t"),

                new Product("phap","123"),
                new Product("vu","123"),
                new Product("duy","123"),
            };
        }



        public override void InsertPhone(string name,string phone)
        {
            int index = Check(name);
            if (index == -1)
            {
                Product phonenew = new Product(name, phone);
                PhoneList.Add(phonenew);
                Console.WriteLine("Cập nhật thành công");
            }
            else
            {
                if (((Product)PhoneList[index]).numberphone != phone)
                {
                  ((Product)PhoneList[index]).numberphone += $": {phone}";
                }
                else
                {
                    Console.WriteLine("Not null");
                }
            }
            
        }
                                                           
        
        public override void removePhone(string name)
        {
            int index = Check(name);
            if (index != -1)
            {            
                    PhoneList.RemoveAt(index);
                    Console.WriteLine("Xóa thành công chúc mừng bạn");
                
            }
            else
            {
                Console.WriteLine("Không có ");
            }
        }
        public override void updatePhone(string name, string newphone)
        {
            int index = Check(name);
            if(index == -1)
            {
                Console.WriteLine("Không có tên trong danh sách");
            }
            else
            {               
                ((Product)PhoneList[index]).numberphone = newphone;
                Console.WriteLine("Cập nhật thành công");
            }
        }
        public override void SearchPhone(string name)
        {
            int index = Check(name);
            if(index != -1)
            {
                //((Product)PhoneList[index]).ToString();
                Console.WriteLine(((Product)PhoneList[index]).ToString());
            }
            else
            {
                Console.WriteLine("Không có trong danh sách ");
            }
        }

        public void Show()
        {
            foreach(var pd in PhoneList)
            {
                Console.WriteLine(((Product)pd).ToString());
            }
        }

        public int Check(string name)
        {

            foreach (Product pb in PhoneList)
            {
                if (pb.Names.Equals(name))
                {
                    return PhoneList.IndexOf(pb);

                }

            }
            return -1;

        }

        public override void Sort()
        {
            var customSort = new CustomSort();
            PhoneList.Sort(customSort);
        }
    }
    //public bool Check (string name,out int index) {
    //        index = -1;
    //       foreach(Product iteam in PhoneList)
    //        {
    //           if(iteam.Names.Equals(name))
    //            {
    //                index = PhoneList.IndexOf(iteam);
    //                return true;
    //            };              
    //        }
    //        return false;
    //    }
   
    }
  
    

