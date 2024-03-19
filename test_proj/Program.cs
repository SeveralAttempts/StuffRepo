using System;
using System.Collections.Generic;
using test_proj.Test;
using PatternPract;
using Graphics;
using Virtualization;
using GenericClass;
using ConsoleTest;
using Contest;

namespace test_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Преобразование типов 
            ///////////////////////////////////////////
            //Unit u = new Man(32);
            //Console.WriteLine(u.A);
            //Man m = (Man)u;
            //m.ChangeValue(33);
            //Console.WriteLine(u.A);
            //((Man)u).ChangeValue(34);
            //Console.WriteLine(u.A);

            //Unit u_s = new(1);
            //u = null;
            //Animal m_s = u as Animal ?? new(6, "bark");
            //Console.WriteLine($"{m_s.A}");


            //Unit unit = new Man(32);
            //Console.WriteLine("after unit ctor");
            //Man man = (Man)unit;
            //Console.WriteLine("after man");
            //Animal animal = unit as Animal ?? new(5, "moo");
            ///////////////////////////////////////////

            // Паттерн Компоновщик
            ///////////////////////////////////////////
            //FigureBox box = new("Дима");

            //CompositeGraphic graphic = new(box);
            //graphic.Display();
            ///////////////////////////////////////////

            // Паттерн Цепочка зависимостей
            ///////////////////////////////////////////
            //CharMove cm = new();
            //cm.Move();
            ///////////////////////////////////////////

            // Виртуальыне/скрытые методы и свойства
            ///////////////////////////////////////////
            //Person person = new Employee("bob", "intel"); // виртуальный метод вызывается тот, ссылка класса которого находится в объекте
            //person.Display();
            //Employee pers = new Employee("joe", "mic"); // так как метод в классе наследника не переопределяется,
            //                                          // а просто скрывает реализацию базового класса, то вызывается метод объекта класса который был создан
            //pers.Name = "3";
            //Console.WriteLine(pers.Name);
            ///////////////////////////////////////////

            // Обобщения, boxing/unboxing
            ///////////////////////////////////////////
            //UserCard<int, string> userCard = new(3, "sams");
            //NoneGenericUserCard noneGenericUserCard = new(3, "al");
            //int id = noneGenericUserCard.Id;
            //int s = 5, d = 3;
            //UserCard<int, string>.Test<int>(s, d);
            //Map m = new(5);
            //m.Show();
            ///////////////////////////////////////////


            Contest.Contest.Water();
        }
    }
}
