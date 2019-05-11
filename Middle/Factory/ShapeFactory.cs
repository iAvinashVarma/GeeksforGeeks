using GeeksForGeeks.Middle.Enum;
using GeeksForGeeks.Middle.Interface;
using GeeksForGeeks.Middle.Concrete.Shape;
using GeeksForGeeks.Middle.Concrete.Shape.Triangle;
using System.Collections.Generic;
using GeeksForGeeks.Middle.Observer;

namespace GeeksForGeeks.Middle.Factory
{
    public class ShapeFactory 
    {
        private static volatile ShapeFactory instance;

        private static readonly object sync = new object();

        private ShapeFactory()
        {

        }

        public static ShapeFactory Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(sync)
                    {
                        if(instance == null)
                        {
                            instance = new ShapeFactory();
                        }
                    }
                }
                return instance;
            }
        }

        public void RegisterShapes()
        {
            Shaper.Instance.Register(GetShape(ShapeType.EquilateralTriangle));
            Shaper.Instance.Register(GetShape(ShapeType.RightAngledTriangle));
            Shaper.Instance.Register(GetShape(ShapeType.Square));
            Shaper.Instance.Register(GetShape(ShapeType.Rectangle));
        }

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
                case ShapeType.Rectangle:
                    shape = new Rectangle();
                    break;
                case ShapeType.Square:
                    shape = new Square();
                    break;
            }
            return shape;
        }
    }
}