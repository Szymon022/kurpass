using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;


namespace TDD.Tests
{
	[TestClass()]
	public class StringCalculatorTests
	{
		[TestMethod()]
		public void Returns0ForEmptyStringArgument()
		{
			StringCalculator calculator= new StringCalculator();
			int value = calculator.Calculate("");
			int valueExpected = 0;
			Assert.AreEqual(valueExpected,value);
		}

		[TestMethod()]
		public void ReturnsValueForSingleNumberString()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("23");
			int valueExpected = 23;
			Assert.AreEqual(valueExpected, value);
		}

		[TestMethod()]
		public void ReturnsSumForTwoNumbersDelimitedByComa()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("20,5");
			int valueExpected = 25;
			Assert.AreEqual(valueExpected, value);
		}

		[TestMethod()]
		public void ReturnsSumForTwoNumbersDelimitedByNewline()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("10\n5");
			int valueExpected = 15;
			Assert.AreEqual(valueExpected, value);
		}

		[TestMethod()]
		public void ReturnsSumForThreeNumbersDelimitedByComa()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("10,5,1");
			int valueExpected = 16;
			Assert.AreEqual(valueExpected, value);
		}

		[TestMethod()]
		public void ReturnsSumForThreeNumbersDelimitedByNewline()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("10\n5\n1");
			int valueExpected = 16;
			Assert.AreEqual(valueExpected, value);
		}

		[TestMethod()]
		public void ThrowsErrorForNegativeNumber()
		{
			StringCalculator calculator = new StringCalculator();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calculate("-2"));
		}

		[TestMethod()]
		public void IgnoresValuesGreaterThan1000()
		{
			StringCalculator calculator = new StringCalculator();
			int value = calculator.Calculate("1001");
			int valueExpected = 0;
			Assert.AreEqual(valueExpected, value);
		}
	}
}