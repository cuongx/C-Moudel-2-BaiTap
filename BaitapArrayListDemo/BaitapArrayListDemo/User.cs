namespace BaitapArrayListDemo
{
    class User
    {      
            public string Name { get; set; }
            public string phonenumber { get; set; }

         public User() { }
        public User(string name,string phone)
        {
            Name = name;
            phonenumber = phone;
            
        }
       public override string ToString()
        {
            return "Name " + Name + " Phone " + phonenumber; 
        }
    }
 }
