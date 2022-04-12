using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson3
{
    class ProgramGeneric
    {
        #region Functions
        
        public static void methodExceptionExample()
        {
            try
            {
                Console.WriteLine("Method that contains try catch");

                //виклик методу в середниі якого існують свої try catch конструкції
                throw new Exception("methodExceptionExample new Exception....");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        #region SerializationExamples

        //серіалізація у XML
        public static async void XmlSerializationExample(List<Animal> animalsCollection)
        {
            Console.WriteLine($"---------------XMLSerializationExample----------------");


            //створюємо об'єкт XmlSerializer що приймає типи List<Animal> і List<Cat> 
            //оскільки List, який ми будемо серіалізувати містить об'єкти обох класів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>), new[] { typeof(List<Cat>) });
            Stream fileStream = new FileStream("animalsCollection.xml", FileMode.Create);
            try
            {
                serializer.Serialize(fileStream, animalsCollection);
                fileStream.Close();
                Console.WriteLine("Serialization completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("You can check serealized XML file.  Press ENTER to continue...");
            Console.ReadLine();
        }

        //серіалізація у JSON
        public static async Task JSONSerializationExample(List<Animal> animalsCollection)
        {
            Console.WriteLine($"---------------JSONSerializationExample----------------");

            // збереження данных
            using (var fileStream = new FileStream("animalsCollection.json", FileMode.OpenOrCreate))
            {
                //серіалізація в Json
                string jsonString = JsonConvert.SerializeObject(animalsCollection);
                Console.WriteLine(jsonString);

                // конвертуємо в байти і записуємо в файл
                byte[] array = System.Text.Encoding.Default.GetBytes(jsonString);

                fileStream.Write(array, 0, array.Length);
                Console.WriteLine("Data has been saved to file");
            }

            Console.WriteLine("You can check serealized JSON file.  Press ENTER to continue...");
            Console.ReadLine();

            // зчитування данных
            using (System.IO.StreamReader sr = File.OpenText("animalsCollection.json"))
            {
                var restoredCollection = JsonConvert.DeserializeObject<List<Animal>>(sr.ReadLine());
                Console.WriteLine("Restored Collection");

                foreach (var animal in restoredCollection)
                    Console.WriteLine($"Name: {animal.age}  Speed: {animal.speed} Weight: {animal.GetWeight()}");
            }
        }
        #endregion SerializationExamples

        #endregion Functions

        public static async Task Main(string[] args)
        {
            //--------------- Приклади реалізації інтерфейсів---------------------------
            
            //Колекція створена через реалізацію IEnumerable + IEnumerator
            var myCollection = new MyCollection();
            foreach (var i in myCollection)
            {
                Console.WriteLine(i);
            }

            //Колекція створена через yield
            var сollectionYield = new MyYieldCollection();
            foreach (var i in сollectionYield)
            {
                Console.WriteLine(i);
            }



            //----------------- Приведення і підстановка класів --------------
            Animal animal1 = new Animal();
            Animal someAnimal = new Animal();
            Cat cat1 = new Cat(2, 4, 5);
            Cat cat2 = new Cat();

            var animalsCollection = new List<Animal>();
            //об'єкти з класів наслідників можуть поводитись як об'єкти батьківських класів
            //не можна порушувати принцип SOLID L= Lliskov substitution principle - принцип підстановки
            animalsCollection.Add(cat1);
            animalsCollection.Add(cat2);
            animalsCollection.Add(animal1);
            animalsCollection.Add(new Cat(8, 6, 3));

            var catsCollection = new List<Cat>();

            //ВИБІРКА з Animals лище котів - є коротша форма через LINQ -дивіться нижче
            foreach (var animal in animalsCollection)
            {
                try
                {
                    //приведення типів в даному випадку буде викидати помилки
                    //оскільки не кожен об'єкт Animal можна привести до класу нащадка
                    catsCollection.Add((Cat)animal);
                    Console.WriteLine($"The cat from List says = {cat1.voise}");

                    //виклик методу всередниі якого існують свої try catch конструкції
                    //компілятор зайде всередину methodExceptionExample() і спробує опрацювати код та 
                    //можливі помилки, якщо знайде помилки, то поверне їх у поточний try блок
                    methodExceptionExample();

                    // Створюємо власне виключення
                    if (animal.age < 5) throw new Exception("Age is < 5 ...");
                }
                // ієрархія класів помилок, відловлюються специфічні і потім загальні
                catch (SystemException ex)
                {
                    Console.WriteLine("Here is the SystemException!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) // Exception - загальний\базовий клас для всіх виключень
                {
                    Console.WriteLine("Here is the Exception!");
                    Console.WriteLine(ex.StackTrace);
                }
                // блок finally виконається в обох випадках і при викиданні помилки,
                // і якщо в блоці try помилок не було
                finally
                {
                    Console.WriteLine("Here is a finally block");
                    Console.ReadLine();
                }
            }


            //-------------------LINQ---------------------------------
            //Вибірка об'єкту за параметром
            Cat catNew = catsCollection.First((x) => x.voise == "Meow!");
            Console.WriteLine($"The cat that have voice  = Meow! is the nex: {catNew.age}, {catNew.speed}, {catNew.voise} \n");


            //!!!ВИБІРКА LINQ коротка форма вибірки з animalsCollection лише об'єктів типу Cats і сортування по віку
            foreach (var cat in animalsCollection.OfType<Cat>().OrderBy(x => x.age).ToList())
            {
                Console.WriteLine($"The sorted cat from List = {cat.age}, {cat.speed}, {cat.voise}");
            }


            #region Generics
            //----------------------------- Generics узагальнені типи ------------
            //Ініціалізаціє об'єкту з узагальненим типом
            var someRestaurant = new Restaurant<Food>();

            //об'єкт класу Restauranr приймає як параметр об'єкт будь-якого класу який реалізував інтерфейс ICook 
            someRestaurant.MadeFood(new Fish());
            

            var veganRestaurant = new Restaurant<string>();
            veganRestaurant.MadeFood(new Plants());

            // вже не вийде зробити їжу з риби у веганському ресторані оскільки ми 
            // його типізували викликавши як new Restaurant<string>
            //      veganRestaurant.MadeFood(new Fish());
            #endregion Generics


            XmlSerializationExample(animalsCollection);


            catsCollection.Add(new Cat(1, 2, 3));
            catsCollection.Add(new Cat(2, 3, 4));

            await JSONSerializationExample(animalsCollection);

        }
    }

    //приклад класу, що реалізує IEnumerable через ключове слово yield
    class MyYieldCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "yield Hello world!";
            yield return "yield Hello world!1";
            yield return "yield Hello world!2";
            yield return "yield Hello world!3";
        }
    }
}