﻿Maths maths = new Maths();

Console.WriteLine(maths.Sum(2, 5));
Console.WriteLine(maths.Sum(1.3, 3.6));
Console.WriteLine(maths.Sum(3, 2, 4));

Animal dog = new Dog();
Animal cat = new Cat();

dog.MakeSound();
cat.MakeSound();
//Animal animal=new Animal(); Error! Object cannot be created directly from abstract classes