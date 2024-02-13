using InPursuitOfHappiness;
using RequiemForDream;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp19
{
    public class CarParkingArray
    {
        private CarParking[] arr; // объявление приватного массива элементов типа CarParking
        private static int objectsCounter = 0;
        private static int CollectionsCointer = 0;
        public CarParkingArray()// без параметров
        {
            arr = new CarParking[0];
            CollectionsCointer++;
        }
        public CarParkingArray(int length)
        {
            // конструктор с параметром для случайной генерации значений
            arr = new CarParking[length]; // инициализация массива с указанной длиной
            CollectionsCointer++;
            objectsCounter += length;
            Random random = new Random(); // создание объекта Random для генерации случайных значений

            for (int i = 0; i<length; i++)
            {


                arr[i] = new CarParking();
                arr[i].NumSlots= random.Next(100);
                arr[i].NumCars= random.Next(100);
            }
        }
        public CarParkingArray(int length, string inputMessage)// c клавы
        {
            arr = new CarParking[length];
            CollectionsCointer++;
            objectsCounter +=length;
            for (int i = 0; i < length; i++)
            {
                arr[i] = new CarParking();
                Console.WriteLine($"{inputMessage} {i+1}");
                arr[i].NumSlots = CollectionFunctions.CheckMessage("Введите kоличесво машин - ");
                arr[i].NumCars = CollectionFunctions.CheckMessage("Введите количество мест - ");
            }
        }
        public CarParkingArray(CarParkingArray copy)
        {
            // конструктор копирования, реализующий глубокое копирование
            arr = new CarParking[copy.arr.Length]; // инициализация массива с той же длиной, что и у другого объекта
            
            
            for (int i = 0; i < copy.arr.Length; i++)
            {
                arr[i] = new CarParking(copy.arr[i].NumSlots, copy.arr[i].NumCars);
            }
        }
        public void ViewingElements()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Элемент {i+1}:");
                Console.WriteLine("Количество машин - " + arr[i].NumCars);
                Console.WriteLine("Количество мест - " + arr[i].NumSlots);

            }
        }

        public CarParking this[int index]// индексация
        {
            // реализация индексатора для доступа к элементам массива
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    return null;
                }

                return arr[index];

               /* else
                {
                    throw new ArgumentException("Значение должно быть от 0 до arr.Lenght");
                }*/
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    return;
                }
                arr[index] = value;

                /*else
                {
                    throw new ArgumentException("Значение должно быть от 0 до arr.Lenght");
                }*/
            }
        }
        public int ReturnArrayLength()
        {
            return arr.Length;
        }

        public static int ArraysCounter()
        {
            return CollectionsCointer;
        }

        public static int ObjectsCounter()
        {
            return objectsCounter;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is CarParkingArray arr)
            {
                return this == arr;
            }
            else return false;

            
            
        }

    }
 }
    

