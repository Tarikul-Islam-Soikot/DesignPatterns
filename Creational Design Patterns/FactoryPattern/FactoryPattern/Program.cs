using FactoryPattern;
using FactoryPattern.Interface;
using static FactoryPattern.Helper.GlobalEnum;


ShapeFactory shapeFactory = new ShapeFactory();

IShape circle = shapeFactory.CreateInstance(ShapeType.Circle);
IShape triangle = shapeFactory.CreateInstance(ShapeType.Triangle);

circle.ShowMessage();
triangle.ShowMessage();

