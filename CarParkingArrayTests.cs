global using Microsoft.VisualStudio.TestTools.UnitTesting;
using InPursuitOfHappiness;
using RequiemForDream;
using System;
using ConsoleApp19;
namespace UnitTests

{
    [TestClass]
    public class CarParkingArrayTests
    {
        [TestMethod]
        public void CarParkingArray_EmptyConstructorTests()
        {
            CarParkingArray cpArray = new CarParkingArray();
            Assert.AreEqual(0, cpArray.ReturnArrayLength());
        }

        [TestMethod]
        public void CarParkingArray_WithParametrsConstructor()
        {
            int lenght = 10;
            CarParkingArray cpArray = new CarParkingArray(lenght);
            Assert.AreEqual(lenght, cpArray.ReturnArrayLength());
        }

        [TestMethod]
        public void CarParkingArray_CopyConstructor()
        {
            CarParkingArray copy = new CarParkingArray(10);
            CarParkingArray cpArray = new CarParkingArray(copy);
            Assert.AreEqual(copy.ReturnArrayLength(), cpArray.ReturnArrayLength());
            for (int i = 0; i < copy.ReturnArrayLength(); i++)
            {
                Assert.AreEqual(copy[i].NumSlots, cpArray[i].NumSlots);
                Assert.AreEqual(copy[i].NumCars, cpArray[i].NumCars);
            }
        }
        [TestMethod]
        public void CarParking_ReturnArrayLength()

        {
            int lenght = 5;
            CarParkingArray arr = new CarParkingArray(5);
            Assert.AreEqual(lenght, arr.ReturnArrayLength());
        }
        [TestMethod]
        public void CarParkingArray_Indexer()
        {
            CarParkingArray arr = new CarParkingArray(10);
            CarParking cp1 = arr[5];
            arr[3] = cp1;
            CarParking cp2 = arr[-1];
            CarParking cp3 = arr[11];
            arr[-1] = cp1;
            arr[11] = cp2;
            Assert.AreEqual(cp1, arr[5]);
            Assert.AreEqual(arr[3], cp1);
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void CarParking_ArrayCounter()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                CarParkingArray arr = new CarParkingArray(2);
                count++;
            }
            Assert.AreEqual(count, CarParkingArray.ArraysCounter());
        }
        [TestMethod]
        public void CarParkingArray_ObjectsCounter()
        {
            int count = 0;
            int lenght = 2;
            for (int i = 0; i < 5; i++)
            {
                CarParkingArray arr = new CarParkingArray(lenght);
                count += lenght;
            }
            Assert.AreEqual(count, CarParkingArray.ObjectsCounter());
        }

        
    }
}
        
