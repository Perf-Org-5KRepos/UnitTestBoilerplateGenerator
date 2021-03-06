using Moq;
using System;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;
using Xunit;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	public class ClassWithNonInterfaceCtorParamTests
	{
		private MockRepository mockRepository;

		private Mock<SomeClass> mockSomeClass;

		public ClassWithNonInterfaceCtorParamTests()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockSomeClass = this.mockRepository.Create<SomeClass>();
		}

		private ClassWithNonInterfaceCtorParam CreateClassWithNonInterfaceCtorParam()
		{
			return new ClassWithNonInterfaceCtorParam(
				this.mockSomeClass.Object);
		}

		[Fact]
		public void TestMethod1()
		{
			// Arrange
			var classWithNonInterfaceCtorParam = this.CreateClassWithNonInterfaceCtorParam();

			// Act


			// Assert
			Assert.True(false);
			this.mockRepository.VerifyAll();
		}
	}
}
