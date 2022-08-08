namespace BasicForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is an array, luckyNumbers is the collection of variables
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
                
            }

            Console.ReadLine();
        }
    }
}