using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Sort
{
    public class InsertionSort : ISort<int>
    {
        public int[] GetOrder(int[] arr)
        {
            int number = arr.Length;
            for(int i = 1; i < number; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}