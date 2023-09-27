namespace Missing_Number
{
    public class ArrayUtils
    {
        public static int NotContains(int[] array)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in array)
            {
                if (num > 0)
                {
                    set.Add(num);
                }
            }

            int smallestPositive = 1;
            while (set.Contains(smallestPositive))
            {
                smallestPositive++;
            }

            return smallestPositive;
        }

        public static void Main(string[] args)
        {
            int[] array = { 4, 3, 8, 5, 1, 2, 6 };
            int result = NotContains(array);

            Console.WriteLine($"The smallest integer greater than 0 not in the array is: {result}");
        }
    }
}

