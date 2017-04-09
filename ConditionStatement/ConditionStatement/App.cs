namespace CSD
{
    class App
    {
        public static void Main()
        {
            int a, b ,c;

            System.Console.Write("a: ");
            a = int.Parse(System.Console.ReadLine());

            System.Console.Write("b: ");
            b = int.Parse(System.Console.ReadLine());

            System.Console.Write("c: ");
            c = int.Parse(System.Console.ReadLine());

            int max = a > b ? a > c ? a : c : b > c ? b : c;

            System.Console.WriteLine(max);
        }
    }
}