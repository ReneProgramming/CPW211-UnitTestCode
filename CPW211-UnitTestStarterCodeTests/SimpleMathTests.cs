using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10, 15)]
        [DataRow(0, 100, 100)]
        [DataRow(-1, -10, -11)]
        [DataRow(0, 0, 0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2, double returnedSum)
        {
            // Act
            double result = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(returnedSum, result);
        }

        [TestMethod()]
        [DataRow(5, 2, 3)]
        [DataRow(10, 10, 0)]
        [DataRow(-5, -5, 0)]
        [DataRow(0, 0, 0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1,double num2,double returnedDifference )
        {
            // Act 
            double result = SimpleMath.Subtract(num1, num2);

            // Assert 
            Assert.AreEqual(returnedDifference, result);

        }

        [TestMethod()]
        [DataRow(5, 10, 50)]
        [DataRow(0, 100, 0)]
        [DataRow(-1, -10, 10)]
        [DataRow(3, 0, 0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2, double returnedProduct)
        {
            // Act
            double result = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(returnedProduct, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(10, 0));
            Assert.AreEqual("Denominator cannot be zero", exception.Message);
        }


        [TestMethod()]
        [DataRow(10, 2, 5)]
        [DataRow(100, 10, 10)]
        [DataRow(-20, -4, 5)]
        [DataRow(0, 10, 0)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2, double returnedQuotient )
        {
            // Act
            double result = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(returnedQuotient, result);
        }
    }
}