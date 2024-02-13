using InPursuitOfHappiness;
using System;
using ConsoleApp19;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RequiemForDream
{
    public class CollectionFunctions
    {
        public static int CheckMessage(string text)// для ввода с клавы из CarParkingArray,ну и для вывода сообщений впринципе
        {
            int num = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.WriteLine(text);
                string message = Console.ReadLine();
                isCorrect = int.TryParse(message, out num);
                if (!isCorrect)
                {
                    Console.WriteLine("Ошибка:Неверное значение");
                }
            }
            return num;
        }
        //для конструкторов
        public static void CreateEmpty()//для пустого конструктора
        {
            CarParking cp = new CarParking();
            cp.Print();
        }
        public static CarParking CreateWithParameters()// для комтруктрора с параментрами
        {
            int numSlots = CheckMessage("Введите количество слотов -  ");
            int numCars = CheckMessage("Введите количество машин - ");
            CarParking cp = new CarParking(numSlots, numCars);
            return cp;
        }
        public static CarParking CreateWithParameters1()// для комтруктрора с параментрами
        {
            int numSlots = CheckMessage("Введите количество слотов -  ");
            int numCars = CheckMessage("Введите количество машин - ");
            CarParking cp1 = new CarParking(numSlots, numCars);
            return cp1;
        }
        public static CarParking CreateWithParameters2()// для комтруктрора с параментрами
        {
            int numSlots = CheckMessage("Введите количество слотов -  ");
            int numCars = CheckMessage("Введите количество машин - ");
            CarParking cp2 = new CarParking(numSlots, numCars);
            return cp2;
        }
        public static void CopyParameters() // для копирующего
        {
            CarParking park1 = new CarParking();
            Console.WriteLine("Парковка поданная для копирования - " );
            park1.Print();
            CarParking park2 = new CarParking(park1);
            Console.WriteLine("Результат копирования - ");
            park2.Print();
        }
        public static void Summa()
        {
            
            CarParking cp1 = CreateWithParameters1();
            CarParking cp2 = CreateWithParameters2();
           
            (cp1+cp2).Print();
        }
        public static void Comparison1()// вторая парковка загруженее первой
        {

            CarParking cp1 = CreateWithParameters1();
            CarParking cp2 = CreateWithParameters2();

            Console.WriteLine(cp1.numCars < cp2.numCars && cp1.numSlots > cp2.numSlots);
        }
        public static void Comparison()// перая парковка загруженее второй
        {

            CarParking cp1 = CreateWithParameters1();
            CarParking cp2 = CreateWithParameters2();

            Console.WriteLine(cp1.numCars > cp2.numCars && cp1.numSlots < cp2.numSlots);
        }
        public static void Exclipint() // явная
        {
            CarParking cp = CreateWithParameters();
            Console.WriteLine($"не хвататет {(int)(cp.numSlots * 0.8)- cp.numCars }");
        }
        public static void Imclipint() // неявная
        {
            CarParking cp = CreateWithParameters();
            Console.WriteLine(cp.numCars < cp.numSlots);
        }
        public static void CalcullateOccupancyForWork()//для первой части-вычисление загруженности парковки
        {
            CarParking cp = CreateWithParameters();
            double occupancy = cp.CalculateOccupancy();
            Console.WriteLine($"Загруженность = {occupancy}");
        }
        public static void CalculateOccupancyStaticForWork()// для первой части но через функцию а не метод
        {
            int numSlots = CheckMessage("Введите количество слотов -  ");
            int numCars = CheckMessage("Введите количество машин - ");
            double occupancy = CarParking.CalculateOccupancyStatic(numSlots, numCars);
            Console.WriteLine($"Загруженность = {occupancy}");
        }
        public static void AddCars() //оператор добавления
        {
            CarParking cp = CreateWithParameters();
            cp.num_Cars++;
            cp.Print();
        }

        public static void DeleteCars()// оператор вычитания
        {
            CarParking cp = CreateWithParameters();
            cp.num_Cars--;
            cp.Print();
        }
        public static void CreateEmptyArray()// создание пустова массива
        {
            CarParkingArray arr = new CarParkingArray();
            Console.WriteLine("Создан пустой массив");
        }

        public static CarParkingArray CreateRandomArray()// рандомное создание массива
        {
            int length = CheckMessage("Введите длину массива");
            CarParkingArray arr = new CarParkingArray(length);
            return arr;
        }
        public static void CreatePersonalArray()// создание массива в ручную
        {
            int length = CheckMessage("Введите длину массива");
            CarParkingArray arr = new CarParkingArray(length, "Элемент");
            arr.ViewingElements();
        }
        public static void CopyArray()// глубокое копирование
        {
            Console.WriteLine("Создание массива для копирования - ");
            CarParkingArray arr = CreateRandomArray();
            CarParkingArray copiedArray = new CarParkingArray(arr);
            copiedArray.ViewingElements();
        }
        public static void ShowIndexerRewrite() // не сущ
        {
            CarParkingArray array = CreateRandomArray();
            CarParking cp = CreateWithParameters();
            int num = CheckMessage("Введите индекс");
            if (num > 0 && num < array.ReturnArrayLength())
            {
                Console.WriteLine("Массив до записи объекта:");
                array.ViewingElements();
                Console.WriteLine("Массив после записи объекта:");
                array[num] = cp;
                array.ViewingElements();
            }
            else
            {
                array[num] = cp;
            }
        }
        public static void ShowIndexerGet()
        {
            CarParkingArray array = CreateRandomArray();
            CarParking cp = CreateWithParameters();
            int num = CheckMessage("Введите индекс");
            if (num > 0 && num < array.ReturnArrayLength())
            {
                Console.WriteLine("Выбранный элемент:");
                array[num].Print();
            }
            else
            {
                array[num].Print();
            }
        }
    }
}
