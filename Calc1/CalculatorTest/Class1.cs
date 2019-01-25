using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;


namespace CalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            {
                //Arrange
                double number1 = 3.4;
                double number2 = 5.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new   Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            

            public void GetAddition_Input8point4and6point6_Returns15point0()
            { //Arrange
                double number1 = 8.4;
                double number2 = 6.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input4point4and5point6_Returns10point0()
            { //Arrange
                double number1 = 4.4;
                double number2 = 5.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input8and5_Returns3()
            { //Arrange
                double number1 = 8;
                double number2 = 1;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input9and6_Returns3()
            { //Arrange
                double number1 = 9;
                double number2 = 6;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input6and1_Returns5()
            { //Arrange
                double number1 = 6;
                double number2 = 5;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input5point4and4point5_Returns24point3()
            { //Arrange
                double number1 = 5.4;

                double number2 = 4.5;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
         
            public void GetMultiplication_Input6point4and5point5_Returns35point2()
            { //Arrange
                double number1 = 6.4;
                double number2 = 5.5;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input3point4and3point5_Returns11point9()
            { //Arrange
                double number1 = 3.4;
                double number2 = 3.5;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input2point4and0point6_Returns4point0()
            { //Arrange
                double number1 = 2.4;
                double number2 = 0.6;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input10point8and3point6_Returns3point0()
            { //Arrange
                double number1 = 10.8;
                double number2 = 3.6;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
          
            public void GetDivision_Input3point6and1point2_Returns3point0()
            { //Arrange
                double number1 = 3.6;
                double number2 = 1.2;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }


}
    

