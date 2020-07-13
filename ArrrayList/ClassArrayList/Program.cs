using System;
using System.Collections;
namespace ClassArrayList
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        /// <summary>
        /// Override phương thức ToString để khi cần có thể in thông tin của object ra cho nhanh.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Name: " + name + " | Age: " + age;
        }
    }
    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Person p1 = x as Person;
            Person p2 = y as Person;

            /*
             * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
             * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
             * Chi tiết về exception sẽ được trình bày ở những bài học sau.
             */
            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                /*
                 * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                 * lớn hơn, bằng, bé hơn.
                 */
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 danh sách kiểu ArrayList rỗng
            ArrayList arrPersons = new ArrayList();

            // Thêm 3 Person vào danh sách
            arrPersons.Add(new Person("Nguyen Van A", 18));
            arrPersons.Add(new Person("Nguyen Van B", 25));
            arrPersons.Add(new Person("Nguyen Van C", 20));

            // In thử danh sách Person ban đầu ra.
            Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            /* 
             * Thực hiện sắp xếp danh sách Person theo tiêu chí đã được định nghĩa 
             * trong phương thức Compare của lớp SortPerson (tuổi tăng dần).
             */
            arrPersons.Sort();
            arrPersons.Reverse();
            // In danh sách Person đã được sắp xếp ra màn hình.
            Console.WriteLine();
            Console.WriteLine("Danh sach Person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
