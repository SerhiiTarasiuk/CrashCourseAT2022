namespace Lesson2
{
    class Restaurant
    {
        //Метод MadeFood(ICook someFood) зможе приймати в себе БУДЬ\ЯКИЙ
        //об'єкт, клас якого реалізував логіку інтерфейсу ICook
        public void MadeFood(ICook someFood)
        {
            someFood.GetFood();
        }
    }
}
