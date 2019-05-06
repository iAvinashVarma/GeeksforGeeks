using System.Text;
using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete
{
    public class LeftAngledTriangle : IShape
    {
        public string GetShapeVaue()
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