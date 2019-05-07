using System.Text;
using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Triangle
{
    public class EquilateralTriangle : IShape
    {
        public string GetValue()
        {
            int shapeSize = 5;
            var shape = new StringBuilder();
            for(int i = 1; i <= shapeSize; i++)
            {
                for(int j = shapeSize - 1; j >= i; j--)
                {
                    shape.Append(" ");
                }
                for(int k = 1; k <= (2*i-1); k++)
                {
                    shape.Append("*");
                }
                shape.AppendLine();
            }
            return shape.ToString();
        }
    }
}