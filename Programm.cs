using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks ;
using RequiemForDream;
using ConsoleApp19;

namespace InPursuitOfHappiness
{
    
    using System;
    using System.Reflection.Metadata;

    public class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            while (message != "20")
            
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - создание пустой парковки");
                Console.WriteLine("2 - создание парковки с параметрами");
                Console.WriteLine("3 - копирование парковки");
                Console.WriteLine("4 - вычислить загруженность парковки методом класса");
                Console.WriteLine("5 - вычислить загруженность парковки статичным методом");
                Console.WriteLine("6 - добавление машины");
                Console.WriteLine("7 - вычитание машины");
                Console.WriteLine("8 - создание пустого массива");
                Console.WriteLine("9 - рандомное создание массива");
                Console.WriteLine("10 - создание массива вручную");
                Console.WriteLine("11 - копирование массива");
                Console.WriteLine("12 - показать работу индексатора");
                Console.WriteLine("13 - Нахождение  минимально-зашруженной парковки в массиве");
                Console.WriteLine("14 - вывод количества обьектов");
                Console.WriteLine("15 - вывод количества созданных массивов");
                Console.WriteLine("16 - проверка обьеденения двух парковок в одну");
                Console.WriteLine("17 - проверка что первая парковка загруженее второй");
                Console.WriteLine("18 - проверка что вторая парковка загруженее первой");
                Console.WriteLine("19 - явная (не хватает до загрузки)");
                Console.WriteLine("20 - неявная(есть ли места на парковке)");
                Console.WriteLine("21 - закочить выполнение программы");
                message = Console.ReadLine();
                switch(message)
                {
                    case "1":
                        CollectionFunctions.CreateEmpty();
                        Console.ReadLine();
                        break;
                    case "2":
                        CarParking cp = CollectionFunctions.CreateWithParameters();
                        cp.Print();
                        Console.ReadLine();
                        break;
                    case "3":
                        CollectionFunctions.CopyParameters();
                        Console.ReadLine();
                        break;
                    case "4":
                        CollectionFunctions.CalcullateOccupancyForWork();
                        Console.ReadLine();
                        break;
                    case "5":
                        CollectionFunctions.CalculateOccupancyStaticForWork();
                        Console.ReadLine();
                        break;
                    case "6":
                        CollectionFunctions.AddCars();
                        Console.ReadLine();
                        break;
                    case "7":
                        CollectionFunctions.DeleteCars();
                        Console.ReadLine();
                        break;
                    case "8":
                        CollectionFunctions.CreateEmptyArray();
                        Console.ReadLine();
                        break;
                    case "9":
                        CarParkingArray arr = CollectionFunctions.CreateRandomArray();
                        arr.ViewingElements();
                        Console.ReadLine();
                        break;
                    case "10":
                        CollectionFunctions.CreatePersonalArray();
                        Console.ReadLine();
                        break;
                    case "11":
                        CollectionFunctions.CopyArray();
                        Console.ReadLine();
                        break;
                    case "12":
                        Console.WriteLine("Перезапись элемента в массив - ");
                        CollectionFunctions.ShowIndexerRewrite();
                        Console.WriteLine("Выбор элемента из массива - ");
                        CollectionFunctions.ShowIndexerGet();
                        Console.ReadLine();
                        break;
                    case "13":
                        CarParkingArray array = CollectionFunctions.CreateRandomArray();
                        Console.WriteLine($"Минимальнозагруженная парковка: {MinPark(array)}"+ $"    Осталось мест: {MinParkDifference(array)}");
                        
                        Console.ReadLine();
                        break;
                    case "14":
                        Console.WriteLine($"Количество созданных объектов: {CarParkingArray.ObjectsCounter()}");
                        Console.ReadLine();
                        break;
                    case "15":
                        Console.WriteLine($"Количество созданных массивов: {CarParkingArray.ArraysCounter()}");
                        Console.ReadLine();
                        break;
                    case "16":
                        CollectionFunctions.Summa();
                        Console.ReadLine();
                        break;
                    case "17":
                        CollectionFunctions.Comparison();
                        Console.ReadLine();
                        break;
                    case "18":
                        CollectionFunctions.Comparison1();
                        Console.ReadLine();
                        break;
                    case "19":
                        CollectionFunctions.Exclipint();
                        Console.ReadLine();
                        break;
                    case "20":
                        CollectionFunctions.Imclipint();
                        Console.ReadLine();
                        break;
                    case "21": break;
                    default:
                        Console.WriteLine("Выбранной команды не существует");
                        break;


                }

            }

            Console.ReadLine();
        }
        public static double MinPark(CarParkingArray array)// для 3 части вычисление минимальной парковки
        {
            double minpark = 9999999999;
            int leastOccupiedSpotIndex = 0;
            double result = 0;
            int Length = array.ReturnArrayLength();
            for (int i = 0; i < Length; i++)
            {
                double occupancy = array[i].CalculateOccupancy();
                double difference = array[i].CalculateDifference();
                if (minpark > occupancy)
                {
                    minpark = occupancy;

                    leastOccupiedSpotIndex = i;
                    result= difference;
                }

            }

            return leastOccupiedSpotIndex;
        }
            public static double MinParkDifference(CarParkingArray array)// просто чтобы 2 значения вывести))))
            {
            double minpark = 9999999999;
            int leastOccupiedSpotIndex = 0;
            double result = 0;
            int Length = array.ReturnArrayLength();
            for (int i = 0; i < Length; i++)
            {
                double occupancy = array[i].CalculateOccupancy();
                double difference = array[i].CalculateDifference();
                if (minpark > occupancy)
                {
                    minpark = occupancy;

                    leastOccupiedSpotIndex = i;
                    result= difference;
                }

            }

            return result;

        }

        
    }
    }
