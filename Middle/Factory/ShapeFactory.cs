using GeeksForGeeks.Middle.Enum;
using GeeksForGeeks.Middle.Interface;
using GeeksForGeeks.Middle.Concrete.Triangle;
using System.Collections.Generic;
using GeeksForGeeks.Middle.Observer;

namespace GeeksForGeeks.Middle.Factory
{
    public class ShapeFactory 
    {
        public IShape GetShape(ShapeType shapeType)
        {
            IShape shape = null;
            switch(shapeType)
            {
                case ShapeType.RightAngledTriangle:
                    shape = new RightAngledTriangle();
                    break;
                case ShapeType.EquilateralTriangle:
                    shape = new EquilateralTriangle();
                    break;
            }
            return shape;
        }
    }
}