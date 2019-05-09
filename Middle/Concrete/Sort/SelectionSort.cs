using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Sort
{
    public class SelectionSort : ISort<int>
    {
        public int[] GetOrder(int[] arr)
        {
            int number = arr.Length;
            for(int i = 0 ; i < number - 1; i++)
            {
                int minimumIndex = i;
                for(int j = i + 1; j < number; j++)
                {
                    if(arr[j] < arr[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }
                int temporaryNumber = arr[minimumIndex];
                arr[minimumIndex] = arr[i];
                arr[i] = temporaryNumber;
            }
            return arr;
        }
    }
}