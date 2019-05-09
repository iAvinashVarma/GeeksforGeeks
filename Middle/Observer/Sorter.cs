using System.Collections.Generic;
using GeeksForGeeks.Middle.Interface;
using System;
using System.Linq;

namespace GeeksForGeeks.Middle.Observer
{
    public class Sorter<T>
    {
        private const string divider = "------------------------------------"; 
        
        private static volatile Sorter<T> instance = null;

        private static readonly object syncObject = new object();

        private List<ISort<T>> _sorters = null;

        private Sorter()
        {
            _sorters = new List<ISort<T>>();
        }

        public static Sorter<T> Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(syncObject)
                    {
                        if(instance == null)
                        {
                            instance = new Sorter<T>();
                        }
                    }
                }
                return instance;
            }
        }

        public void Register(ISort<T> sort)
        {
            if(!_sorters.Contains(sort))
            {
                _sorters.Add(sort);
            }
        }

        public void Notify(T[] arr)
        {
            foreach(var sorter in _sorters)
            {
                Console.WriteLine(divider);
                var order = sorter.GetOrder(arr);
                Console.WriteLine("{0} - {1}", sorter.GetType().Name, string.Join(",", order.Select(o => o.ToString()).ToArray()));
                Console.WriteLine(divider);
            }
        }
    }
}