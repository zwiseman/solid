using Xunit;
using solidproj;

namespace tests
{
    public class bstTest
    {
        [Fact]
        public void FirstTest() {
            Assert.NotEqual("HelloTest", "HelloWorld");
        }

        [Fact]
        public void TestBstInOrderTraversal() {
            int [] input = {20, 99, -1, 40, -70, 1000, -491, 27, 88};
            
        }
    }
}