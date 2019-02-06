using solidproj;
using Xunit;

namespace tests {
    public class bstTest {
        BinarySearchTree bst = new BinarySearchTree ();

        [Fact]
        public void FirstTest () {
            Assert.NotEqual ("HelloTest", "HelloWorld");
        }

        [Fact]
        public void BstSizeZeroOnInitialization () {
            Assert.Equal (0, bst.GetSize ());
        }

        [Fact]
        public void BstRootIsNullOnInitialization () {
            Assert.Null(bst.GetRoot());
        }

        [Fact]
        public void InsertBstInsertsNodeIntoTreeStructure () {
            //Given

            //When

            //Then
        }

        [Fact]
        public void TestBstInOrderTraversal () {
            int[] input = { 20, 99, -1, 40, -70, 1000, -491, 27, 88 };

        }
    }
}