using Xunit;
using UnitTest;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program program = new Program();
            int result=program.Add(10, 10);
            Assert.Equal(20,result);
            
        }
    }
}