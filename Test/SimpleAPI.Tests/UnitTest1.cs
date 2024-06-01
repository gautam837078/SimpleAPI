using SimpleAPI;
namespace SimpleAPI.Tests;
public class UnitTest1
{
   
    ValuesController vcobj=new ValuesController(); // Arrange pattern
    [Fact]
    public void Test1()
    {

    }

        [Fact]
        public void GetReturnCollectNumber()
        {
        //Given
         var ID= vcobj.Get(1); // Act Test
         // When

         //Then         
         Assert.Equal("Gautam",ID); // Assert  Test
        }
}