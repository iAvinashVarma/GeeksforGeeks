using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Sort
{
    public class QuickSort : ISort<int>
    {
        public int[] GetOrder(int[] arr)
        {
            PerformSort(arr, 0, arr.Length - 1);
            return arr;
        }

        private int PerformPartition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for(int j = low; j < high; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    int tempOne = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempOne;
                }
            }

            int tempTwo = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempTwo;

            return i + 1;
        }

        private void PerformSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int partition = PerformPartition(arr, low, high);
                PerformSort(arr, low, partition - 1);
                PerformSort(arr, partition + 1, high);
            }
        }
    }
}