using System.Collections.Generic;
using GeeksForGeeks.Middle.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksForGeeks.Middle.Observer
{
    public class Sorter
    {
        protected const string divider = "------------------------------------"; 
        
        private static volatile Sorter instance = null;

        private static readonly object syncObject = new object();

        private List<ISort<int>> _sorters = null;

        private Sorter()
        {
            _sorters = new List<ISort<int>>();
        }

        public static Sorter Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(syncObject)
                    {
                        if(instance == null)
                        {
                            instance = new Sorter();
                        }
                    }
                }
                return instance;
            }
        }

        public void Register(ISort<int> sort)
        {
            if(!_sorters.Contains(sort))
            {
                _sorters.Add(sort);
            }
        }

        public void Notify()
        {
            foreach(var s in _sorters)
            {
                var random = new Random();
                int[] shuffleNumbers = Enumerable.Range(1, 10).Select(r => random.Next(1, r + 100)).ToArray();
                Console.WriteLine(divider);
                Console.WriteLine("{0} - {1}", "Given random order", string.Join(",", shuffleNumbers.Select(o => o.ToString()).ToArray()));
                var order = s.GetOrder(shuffleNumbers);
                Console.WriteLine("{0} - {1}", s.GetType().Name, string.Join(",", order.Select(o => o.ToString()).ToArray()));
                Console.WriteLine(divider);
            }
        }
    }
}