using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Sort
{
    public class HeapSort : ISort<int>
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

        private void Heapify(int[] arr, int number, int index)
        {
            int largest = index;
            int left = 2*index + 1;
            int right = 2*index + 2;

            if(left < number && arr[left] > arr[largest])
            {
                largest = left;
            }

            if(right < number && arr[right] > arr[largest])
            {
                largest = right;
            }

            if(largest != index)
            {
                int swap = arr[index];
                arr[index] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, number, largest);
            }
        }

        private void PerformSort(int[] arr)
        {
            int number = arr.Length;

            for(int index = number / 2 - 1; number >= 0; number--)
            {
                Heapify(arr, number, index);
            }

            for(int index = number - 1; number >= 0; number--)
            {
                int temp = arr[0];
                arr[0] = arr[index];
                arr[index] = temp;

                Heapify(arr, number, index);
            }
        }
    }
}