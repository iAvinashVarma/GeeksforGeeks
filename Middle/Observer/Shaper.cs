using System.Collections.Generic;
using GeeksForGeeks.Middle.Interface;
using System;

namespace GeeksForGeeks.Middle.Observer
{
    public class Shaper
    {
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
            foreach(var shaper in _shapers)
            {
                Console.WriteLine(shaper.GetValue());
            }
        }
    }
}