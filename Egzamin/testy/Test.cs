using konsolowa;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace Test
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            int[] arr = GetRandomArray(100);
            List<int> list = arr.ToList();
            list.Sort();
            int[] sortedArray = list.ToArray();
            konsolowa.Program.BubbleSort(arr);
            Assert.Equal(sortedArray, arr);
        }

        int[] GetRandomArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1,1001); 
            }
            
            return array;
        }
    }
}