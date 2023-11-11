using static FactoryPattern.Helper.GlobalMessage;
using FactoryPattern.Interface;

namespace FactoryPattern.Implementation
{
    public class Circle: IShape
    {
        public void ShowMessage()
        {
            Console.WriteLine(string.Format(ShapeCreationInfo, nameof(Circle))); 
        } 
    }
}
