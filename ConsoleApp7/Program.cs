using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.Type = "Cat";
            cat.Age = 5;
            cat.Name = "Вискас";
            cat.Sound = "Mew";
            Console.WriteLine(cat.getInfo());
            Console.WriteLine(cat.sayHello());

            Animals Boozer = new Animals();
            Boozer.Type = "Алкаш";
            Boozer.Age = 18;
            Boozer.Name = "дядя Витя";
            Boozer.Sound = "чукушку, уважаемый";
            Console.WriteLine(Boozer.getInfo());
            Console.WriteLine(Boozer.sayHello());
        }
    }
    public class Animals
    {
        public string Type
        {
            get { return Type; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a type");
                }
            }
        }
        public int Age
        {
            get { return Age; }
            set
            {
                if (value < null || value > 100)
                {
                    Console.WriteLine("You have to enter an age ");
                }
            }
        }
        public string Name;
        public string Sound;

        public string getInfo()
        {
            return $"Вид: {Type}\n Возраст: {Age}\n Кличка: {Name}";
        }
        public string sayHello()
        {
            return "Sound";
        }
    }
}
