namespace ListDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "ID " + ID + "Name " + Name + "Email " + Email;
        }
    }
   
}