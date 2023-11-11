using FactoryPattern.Implementation;
using FactoryPattern.Interface;
using static FactoryPattern.Helper.GlobalEnum;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public ShapeFactory() { }

        public IShape CreateInstance(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Circle)
                return new Circle();

            else if (shapeType == ShapeType.Triangle)
                return new Triangle();

            else
                throw new NotImplementedException();
        }
    }
}
