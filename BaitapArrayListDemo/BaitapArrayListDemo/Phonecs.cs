using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BaitapArrayListDemo
{
   abstract class Phone
    {
       public abstract void insertPhone(string name , string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
    }
    class PhoneBook : Phone
    {
        ArrayList PhoneList = new ArrayList();


        public PhoneBook() {

            PhoneList = new ArrayList();

            PhoneList.Add(new User()
            {
                Name = "Cường",
                phonenumber = "12345678"

            });
            PhoneList.Add(new User()
            {
                Name = "Tèo",
                phonenumber = "123456789"
            });
        }
        public override void insertPhone(string name, string phone)
        {
            int index = Check(name);
            if (index == -1)
            {
                User newphone = new User(name, phone);
                PhoneList.Add(newphone);

                Console.WriteLine("Cập nhật thành công");
            }
            else
            {
                if (((User)PhoneList[index]).phonenumber != phone) {
                    ((User)PhoneList[index]).phonenumber += $"{phone}";
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }

        public override void removePhone(string name)
        {
            int index = Check(name);
            if (index != -1)
            {
                PhoneList.RemoveAt(index);
                Console.WriteLine("Delete Success");
            }
            else
            {
                Console.WriteLine("Not Name");
            }
        }

        public override void SearchPhone(string name)
        {
            int index = Check(name);
            if (index != -1)
            {
                Console.WriteLine(((User)PhoneList[index]).ToString());
            }
            else
            {
                Console.WriteLine("Not found ");
            }

        }

        public override void Sort()
        {
            var custom = new Custom();
            PhoneList.Sort(custom);



        }
    

        public override void updatePhone(string name, string newphone)
        {
            int index = Check(name);
            if(index == -1)
            {
                Console.WriteLine("Not found danh sách");
            }
            else
            {
                ((User)PhoneList[index]).phonenumber = newphone;
                Console.WriteLine("Update Suucess");
            }
        }
        public void Show()
        {
            foreach(var pd in PhoneList)
            {
                Console.WriteLine(((User)pd).ToString());
            }
        }
        public int Check(string name)
        {
             foreach(User pb in PhoneList)
            {
                if (pb.Name.Equals(name))
                {
                    return PhoneList.IndexOf(pb);
                }
            }
            return -1;
        }
    }
}
