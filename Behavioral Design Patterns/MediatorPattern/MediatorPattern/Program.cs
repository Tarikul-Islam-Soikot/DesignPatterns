using MediatorPattern.Implementation;
using MediatorPattern.Interfaces;

ChildMediator child = new ChildMediator();

IPerson father = new Father(child);
IPerson mother = new Mother(child);

child.SetFather(father);
child.SetMother(mother);

father.SendMessage("Hey kid. Ask you mother, why she is crying!");
mother.SendMessage("Tell you father not to talk to me! huh!");
father.SendMessage("Why!! What happend to her!");
mother.SendMessage("Ask your father that how he could forget such an important day!!");
father.SendMessage("Tell her, I didn't forget anything. Here is her gift!");
