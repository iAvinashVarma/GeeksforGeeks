using System;
using GeeksForGeeks.Middle.Observer;
using GeeksForGeeks.Middle.Concrete.Shape;
using GeeksForGeeks.Middle.Concrete.Shape.Triangle;
using GeeksForGeeks.Middle.Concrete.Sort;

namespace GeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaper.Instance.Register(new EquilateralTriangle());
            Shaper.Instance.Register(new RightAngledTriangle());
            Shaper.Instance.Register(new Square());
            Shaper.Instance.Register(new Rectangle());
            Shaper.Instance.Notify();

            int[] arr = { 64, 25, 12, 22, 11}; 
            Sorter<int>.Instance.Register(new SelectionSort());
            Sorter<int>.Instance.Notify(arr);
        }
    }
}
