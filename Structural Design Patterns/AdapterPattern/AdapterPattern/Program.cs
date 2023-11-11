using AdapterPattern;
using AdapterPattern.Implementation;
using AdapterPattern.Interface;


JunkFood junkFood = new JunkFood();
IHealthyFood adapter = new FoodAdapter(junkFood);

Children children = new Children(adapter);
children.HaveFood();