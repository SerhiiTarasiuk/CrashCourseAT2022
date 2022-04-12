using System;

namespace Lesson2
{
    //клас Plants реалізовує інтерфейс ICook - тобто обов'язково прописує логіку для усіх
    //методів, зазначених в описі інтерфейсу ICook. У даному випадку метод GetFood()
    public class Plants : ICook
    {
        // Властивість Age = поле age з методами public get() і private set()
        // викликається в коді через геттер GetAge() і сеттер SetAge() 
        // var somePlant = new Plants();
        // 
        public int Age
        { get; private set; }

        public int height;
        public bool isEdible;


        //метод з інтерфейсу ICook
        public Food GetFood()
        {
            Console.WriteLine("It is your salad");
            return new Food();
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }   
}