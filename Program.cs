using System;
using GeeksForGeeks.Middle.Observer;
using GeeksForGeeks.Middle.Concrete.Triangle;

namespace GeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaper.Instance.Register(new EquilateralTriangle());
            Shaper.Instance.Register(new LeftAngledTriangle());
            Shaper.Instance.Notify();
        }
    }
}
