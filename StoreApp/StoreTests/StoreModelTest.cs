using System;
using Xunit;
using StoreModels;
//Note that models aren't really supposed to be unit tested because they mainly hold data
//You should focus on unit testing logic. Like your BL, or DL. Also, don't unit test UI. (trust me I tried)
namespace StoreTests
{
    public class StoreModelTest
    {
        //3 parts of a unit test: arrange, act, assert:
        // Arrange is all about setting up the things you need for the unit test 
        // Act its doing the thing you wanna test
        // Assert (the inedible kind) is comparing the actual results to the expected outcome

        //Arrange
        private Customer testCustomer = new Customer();

        [Fact]
        public void CustomerNameShouldBeSet()
        {
            string testName = "Customer";
            //Act
            testCustomer.CustomerName = testName;
            //Assert
            Assert.Equal(testName, testCustomer.CustomerName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CustomerNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testCustomer.CustomerName = testName);
        }

    }
}
