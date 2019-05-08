using System.Text;
using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete
{
    public class Rectangle : IShape
    {
        public string GetValue()
        {
            int width = 8;
            int height = 5;
            var sb = new StringBuilder();
            sb.Append(GetHorizontalLine(width));
            sb.Append(GetVerticalLine(width, height));
            sb.Append(GetHorizontalLine(width));
            return sb.ToString();
        }

        private string GetHorizontalLine(int width)
        {
            var sb = new StringBuilder();
            sb.Append("* ");
            for(int i = 0; i < width - 2; i++)
            {
                sb.Append("* ");
            }
            sb.AppendLine("*");
            return sb.ToString();
        }

        private string GetVerticalLine(int width, int height)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < height - 2; i++)
            {
                sb.Append("* ");
                for(int j = 0; j < width - 2; j++)
                {
                    sb.Append("  ");
                }
                sb.AppendLine("*");
            }
            return sb.ToString();
        }
    }
}