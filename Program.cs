using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("мурка", "мяу");
            cat1.ShowInfo();

            Dog dog1 = new Dog("жучка", "гав");
            dog1.ShowInfo();

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; set; } //свойство
        public abstract void Say(); //абстрактный метод
        public void ShowInfo() //метод
        {
            Console.Write($"{Name} ");
            Say();
        }

        public Animal(string name) //конструктор
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Животное"; //значение по умолчанию
            }
            else 
            {
                Name = name;
            }
        }
    }

    class Cat : Animal
    {
        string name;
        string say;
        public override string Name { get => name; set => name = value; }

        public Cat(string name, string say)
            :base(name)
        {
            this.say = say;
        }

        public override void Say()
        {
            Console.WriteLine(say);
        }
    }

    class Dog : Animal
    {
        string name;
        string say;
        public override string Name { get => name; set => name = value; }

        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void Say()
        {
            Console.WriteLine(say);
        }
    }
}
