// 프로그램을 실행하면 운영체제가 운영할수 있는 메모리를 제공한다
// 거기서 우리가 알아야할 메모리는 스택 메모리, 힙 메모리가 있다. (다른것도 더 있지만 두개가 일단 중요)

//스택 : 불안정하고 일시적으로 사용하는 메모리
//void F()
//{
       // int a -> 스택영역안에 들어간 정보 ( 함수가 종료하게 되면 정보가 사라지게 된다. )
//}



namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}