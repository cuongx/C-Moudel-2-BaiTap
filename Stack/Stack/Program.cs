using System;
using System.Collections;
namespace StackDemo1

{
    class StackDemo
    {
        Stack stack = new Stack();
        public void Show()
        {
            stack.Push(5);
            stack.Push(15);
            stack.Push(25);
            stack.Push(35);
            stack.Push(45);
            stack.Push(20);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                
                Stack MyStack4 = new Stack();
                // khởi tạo 1 mảng bất kỳ
                // Tạo 1 Stack rỗng

                StackDemo ac = new StackDemo();
                ac.Show();
                // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
                MyStack4.Push("Education");
                MyStack4.Push("Free");
                MyStack4.Push("HowKteam");

                // Thử sử dụng các phương thức của Stack.
                Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack4.Count);

                // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek.
                Console.WriteLine(" Phan tu dau cua Stack la: {0}", MyStack4.Peek());

                // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
                Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack4.Count);

                // Thực hiện xoá các phần tử ra khỏi Stack.
                Console.WriteLine(" Popping...");
                int Length = MyStack4.Count;
                for (int i = 0; i < Length; i++)
                {
                    Console.Write(" " + MyStack4.Pop());
                }
                Console.WriteLine();

                // Kiểm tra lại số phần tử của Stack sau khi Pop
                Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack4.Count);
            }
        }
    }
}
