namespace ArrayFilter
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            var filteredList = new List<int>();

            foreach (var item in array)
            {
                if (predicate(item))
                {
                    filteredList.Add(item);
                }
            }

            return filteredList.ToArray();
        }
    }
}

namespace ArrayFilter
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenNumbers = numbers.Filter(n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            int[] oddNumbers = numbers.Filter(n => n % 2 != 0);
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        }
    }
}

