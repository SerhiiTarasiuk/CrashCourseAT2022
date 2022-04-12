
namespace Lesson3
{   
    public class Animal
    {
        public int age;
        public int speed;
        protected int weight;

        //порожній конструктор = конструктор по замовчуванню
        //можна його не вказувати, компілятор згенерує його автоматично
        public Animal() { }

        protected string SetAge() {
            this.age = 0;
            return age.ToString();
        }       

        public int GetWeight()
        {
            return this.weight;
        }

        public virtual int move(int a, int b = 1)
        {
            return (a + b) * speed;
        }

    }
}
