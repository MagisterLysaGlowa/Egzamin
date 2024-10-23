namespace konsolowa
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,1001);
            }
            BubbleSort(array);
            PrintArray(array);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("SORTED ARRAY");
            Console.Write("|");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} |");
            }
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
