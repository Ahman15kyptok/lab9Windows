using InPursuitOfHappiness;

using System.Runtime.InteropServices;
namespace UnitTests
{
    [TestClass]
    public class CarparkingTests
    {
        [TestMethod]
        public void TestEpmtyConstructor()//пустой конструктор
        {
            //average
            CarParking cp = new CarParking();
            // act
            // assert
            Assert.AreEqual(0, cp.NumCars);
            Assert.AreEqual(0, cp.NumSlots);
        }
        [TestMethod]
        public void TestWithParametersConstructor()// с параметрами конструктор
        {
            //average
            CarParking cp = new CarParking(5,10);
            // act
            // assert
            Assert.AreEqual(5, cp.NumSlots);
            Assert.AreEqual(10, cp.NumCars);
        }
        [TestMethod]
        public void TestCopyParametersConstructor()// копирующий конструктор
        {
            //average
            CarParking firstCp = new CarParking(32,12);
            // act
            CarParking copyCp = new CarParking(firstCp);
            // assert
            Assert.AreEqual(firstCp.NumSlots,copyCp.NumSlots);
            Assert.AreEqual(firstCp.NumCars, copyCp.NumCars);
        }
        [TestMethod]
        public void TestCalculateOccupancy()// загруженность парковки через метод
        {
            //average
            CarParking cp = new CarParking(15, 5);
            // act
            double occupancy = cp.CalculateOccupancy(); 
            // assert
            Assert.AreEqual(33.33333333333333, occupancy);
           
        }
        [TestMethod]
        public void TestCalculateOccupancyStatic()// загруженность парковки через функцию
        {
            //average
            CarParking cp = new CarParking(15, 5);
            // act
            double occupancy = CarParking.CalculateOccupancyStatic(15,5);
            // assert
            Assert.AreEqual(33.33333333333333, occupancy);

        }
        [TestMethod]
        public void TestAddCars()//operator ++
        {
            //average
            CarParking cp = new CarParking(1, 2);
            // act
            cp.NumCars++;
            // assert
            Assert.AreEqual(1,cp.NumSlots);
            Assert.AreEqual(3,cp.NumCars);
        }
        [TestMethod]
        public void TestRemoveCars()// operator --
        {
            //average
            CarParking cp = new CarParking(1, 2);
            // act
            cp.NumCars--;
            // assert
            Assert.AreEqual(1, cp.NumSlots);
            Assert.AreEqual(1, cp.NumCars);
        }
        [TestMethod]
        public void TestExplicint()// явная
        {
            //average
            CarParking cp = new CarParking(15, 5);
            // act
            
            // assert
            Assert.AreEqual(7, (int)(cp.numSlots * 0.8)- cp.numCars);
            
        }
        [TestMethod]
        public void TestImplicint()// неявная
        {
            //average
            CarParking cp = new CarParking(10, 5);
            // act

            // assert
            Assert.AreEqual(true, cp.numCars < cp.numSlots);

        }
        [TestMethod]
        public void GetObjectCount()
        {
            for (int i = 0; i < 5; i++)
            {
                CarParking cp = new CarParking();
            }
            Assert.AreEqual(5, CarParking.TotalCount());
        }
        [TestMethod]
        public void TestSummaPark()
        {

            CarParking cp1 = new CarParking(10, 5);
            CarParking cp2 = new CarParking(11, 6);
            CarParking result = cp1+cp2;
            Assert.AreEqual(result.numSlots, cp1.numSlots + cp2.numSlots);
            Assert.AreEqual(result.numCars, cp1.numCars + cp2.numCars);

        }
        [TestMethod]
        public void TestComparisonPark()
        {

            CarParking cp1 = new CarParking(10, 5);
            CarParking cp2 = new CarParking(11, 6);
            
            Assert.AreEqual(false, cp1.numCars < cp2.numCars && cp1.numSlots > cp2.numSlots);
            

        }
        [TestMethod]
        public void TestComparisonPark2()
        {

            CarParking cp1 = new CarParking(10, 5);
            CarParking cp2 = new CarParking(11, 6);

            Assert.AreEqual(false, cp1.numCars > cp2.numCars && cp1.numSlots < cp2.numSlots);


        }

    }
}