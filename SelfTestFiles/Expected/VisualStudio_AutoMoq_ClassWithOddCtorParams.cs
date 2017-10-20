using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestClass]
	public class ClassWithOddCtorParamsTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			var mocker = new AutoMoqer();


			// Act
			var classWithOddCtorParams = mocker.Create<ClassWithOddCtorParams>();


			// Assert

		}
	}
}
