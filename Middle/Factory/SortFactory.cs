using GeeksForGeeks.Middle.Enum;
using GeeksForGeeks.Middle.Interface;
using GeeksForGeeks.Middle.Concrete.Sort;
using System.Collections.Generic;
using GeeksForGeeks.Middle.Observer;

namespace GeeksForGeeks.Middle.Factory
{
    public class SortFactory 
    {
        private static volatile SortFactory instance;

        private static readonly object sync = new object();

        private SortFactory()
        {

        }

        public static SortFactory Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(sync)
                    {
                        if(instance == null)
                        {
                            instance = new SortFactory();
                        }
                    }
                }
                return instance;
            }
        }

        public void RegisterSorts()
        {
            Sorter.Instance.Register(new SelectionSort());
            Sorter.Instance.Register(new BubbleSort());
            Sorter.Instance.Register(new QuickSort());
            Sorter.Instance.Register(new HeapSort());
        }
    }
}