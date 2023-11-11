using FactoryPattern.Interface;
using static FactoryPattern.Helper.GlobalMessage;

namespace FactoryPattern.Implementation
{
    public class Triangle: IShape
    {
        public void ShowMessage()
        {
            Console.WriteLine(string.Format(ShapeCreationInfo, nameof(Triangle)));
        }
    }
}
