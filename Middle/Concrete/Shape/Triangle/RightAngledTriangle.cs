using System.Text;
using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Shape.Triangle
{
    public class RightAngledTriangle : IShape
    {
        public string GetValue()
        {
            var shape = new StringBuilder();
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    shape.Append("*");
                }
                shape.AppendLine();
            }
            return shape.ToString();
        }
    }
}