using System;
using GeeksForGeeks.Middle.Factory;
using GeeksForGeeks.Middle.Enum;

namespace GeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            var leftAngledTriangleValue = shapeFactory.GetShape(ShapeType.LeftAngledTriangle).GetShapeVaue();
            Console.WriteLine(leftAngledTriangleValue);
        }
    }
}
