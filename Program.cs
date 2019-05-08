using System;
using GeeksForGeeks.Middle.Observer;
using GeeksForGeeks.Middle.Concrete;
using GeeksForGeeks.Middle.Concrete.Triangle;

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
        }
    }
}
