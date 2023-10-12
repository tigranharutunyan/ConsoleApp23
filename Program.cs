namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 23, 24, 25, 26, 36, 9,17, 8, 4, 1, 2, 6, 3 };
            for(int i = 0;i < number.Length; i++) {

                for (int j = 4; j < 10; j++)
                {
                    if (number[i] % j == 0 )
                    {
                        Console.WriteLine(number[i]);
                        break;
                    }
                  
                }
                
            }
        }
    }
}