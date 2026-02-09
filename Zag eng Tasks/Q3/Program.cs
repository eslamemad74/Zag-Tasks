namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ClassifyNumbers(numbers);
        }

        static void ClassifyNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> primeNumbers = new List<int>();

            
            foreach (int num in numbers)
            {
                if (IsEven(num))
                    evenNumbers.Add(num);
                else
                    oddNumbers.Add(num);

                if (IsPrime(num))
                    primeNumbers.Add(num);
            }

            PrintList("Even Numbers", evenNumbers);
            PrintList("Odd Numbers", oddNumbers);
            PrintList("Prime Numbers", primeNumbers);
        }

       
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        
        static void PrintList(string title, List<int> list)
        {
            Console.Write(title + ": ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
