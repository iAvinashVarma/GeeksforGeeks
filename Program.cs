using System;
using GeeksForGeeks.Middle.Observer;
using GeeksForGeeks.Middle.Factory;
using GeeksForGeeks.Middle.Concrete.Shape;
using GeeksForGeeks.Middle.Concrete.Shape.Triangle;
using GeeksForGeeks.Middle.Concrete.Sort;

namespace GeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory.Instance.RegisterShapes();
            Shaper.Instance.Notify();

            SortFactory.Instance.RegisterSorts();
            Sorter.Instance.Notify();
        }
    }
}
