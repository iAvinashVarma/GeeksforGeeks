using System.Text;
using GeeksForGeeks.Middle.Interface;

namespace GeeksForGeeks.Middle.Concrete.Shape
{
    public class Square : IShape
    {
        public string GetValue()
        {
            var shape = new StringBuilder();
            int size = 5;
            for(int rows = 0; rows < size; rows++)
            {
                for(int columns = 0; columns < size; columns++)
                {
                    if(rows == 0 || columns == 0 || rows == size - 1 || columns == size -1)
                    {
                        shape.Append("* ");
                    }
                    else
                    {
                        shape.Append("  ");
                    }
                }
                shape.AppendLine();
            }
            return shape.ToString();
        }
    }
}