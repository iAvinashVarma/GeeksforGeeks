using System.Collections.Generic;
using GeeksForGeeks.Middle.Interface;
using System;
using System.Threading.Tasks;

namespace GeeksForGeeks.Middle.Observer
{
    public class Shaper
    {
        private const string divider = "------------------------------------"; 

        private static volatile Shaper instance = null;

        private static readonly object mutex = new object();

        private List<IShape> _shapers = null;

        private Shaper()
        {
            _shapers = new List<IShape>();
        }

        public static Shaper Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(mutex)
                    {
                        if(instance == null)
                        {
                            instance = new Shaper();
                        }
                    }
                }
                return instance;
            }
        }

        public void Register(IShape shape)
        {
            if(!_shapers.Contains(shape))
            {
                _shapers.Add(shape);
            }
        }

        public void Notify()
        {
            foreach(var s in _shapers)
            {
                Console.WriteLine(divider);
                Console.WriteLine("{0}:{1}", s.GetType().Name, Environment.NewLine);
                Console.WriteLine(s.GetValue());
                Console.WriteLine(divider);
            }
        }
    }
}