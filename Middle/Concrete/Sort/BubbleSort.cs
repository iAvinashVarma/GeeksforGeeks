using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Sort
{
    public class BubbleSort : ISort<int>
    {
        public int[] GetOrder(int[] arr)
        {
            int number = arr.Length;
            for(int i = 0 ; i < number - 1; i++)
            {
                for(int j = 0; j < number - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temporaryNumber = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temporaryNumber;
                    }
                }
            }
            return arr;
        }
    }
}