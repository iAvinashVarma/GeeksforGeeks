using GeeksForGeeks.Middle.Enum;
using GeeksForGeeks.Middle.Interface;
using GeeksForGeeks.Middle.Concrete;

namespace GeeksForGeeks.Middle.Factory
{
    public class ShapeFactory 
    {
        public IShape GetShape(ShapeType shapeType)
        {
            IShape shape = null;
            switch(shapeType)
            {
                case ShapeType.LeftAngledTriangle:
                    shape = new LeftAngledTriangle();
                    break;
            }
            return shape;
        }
    }
}