using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestClass]
	public class DerivedPropertyInjectedClassTests
	{
		private MockRepository mockRepository;

		private Mock<IInterface3> mockInterface3;
		private Mock<ISomeInterface> mockSomeInterface;
		private Mock<ISomeOtherInterface> mockSomeOtherInterface;

		[TestInitialize]
		public void TestInitialize()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockInterface3 = this.mockRepository.Create<IInterface3>();
			this.mockSomeInterface = this.mockRepository.Create<ISomeInterface>();
			this.mockSomeOtherInterface = this.mockRepository.Create<ISomeOtherInterface>();
		}

		private DerivedPropertyInjectedClass CreateDerivedPropertyInjectedClass()
		{
			return new DerivedPropertyInjectedClass
			{
				Interface3Property = this.mockInterface3.Object,
				MyProperty = this.mockSomeInterface.Object,
				Property2 = this.mockSomeOtherInterface.Object,
			};
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			var derivedPropertyInjectedClass = this.CreateDerivedPropertyInjectedClass();

			// Act


			// Assert
			Assert.Fail();
			this.mockRepository.VerifyAll();
		}
	}
}
