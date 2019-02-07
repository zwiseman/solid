using System.Collections.Generic;
using solidproj;
using Xunit;

namespace tests {
    public class bstTest {
        BinarySearchTree bst = new BinarySearchTree ();

        #region Tests
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
            Assert.Null (bst.GetRoot ());
        }

        [Fact]
        public void InsertBstInsertsNodeIntoTreeStructure () {
            TreeNode root = new TreeNode (10);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);

            // Then
            Assert.Equal (1, bst.GetSize ());
            Assert.Equal (root, bst.GetRoot ());
        }

        [Fact]
        public void InsertMultipleBstInsertsNodeIntoTreeStructure () {
            TreeNode root = new TreeNode (10);
            TreeNode leftchild = new TreeNode (-5);
            TreeNode rightChild = new TreeNode (11);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftchild);
            bst.Insert (rightChild);

            // Then
            Assert.Equal (3, bst.GetSize ());
            Assert.Equal (root, bst.GetRoot ());
            Assert.Equal (leftchild, bst.GetRoot ().GetLeftChild ());
            Assert.Equal (rightChild, bst.GetRoot ().GetRightChild ());
        }

        [Fact]
        public void InsertMultipleBstLeftChildHasRightParent () {
            TreeNode root = new TreeNode (10);
            TreeNode leftchild = new TreeNode (-5);
            TreeNode rightChild = new TreeNode (11);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftchild);
            bst.Insert (rightChild);

            // Then
            Assert.Equal (3, bst.GetSize ());
            Assert.Equal (root, bst.GetRoot ().GetLeftChild ().GetParent ());
        }

        [Fact]
        public void InsertMultipleBstRightChildHasRightParent () {
            TreeNode root = new TreeNode (10);
            TreeNode leftchild = new TreeNode (-5);
            TreeNode rightChild = new TreeNode (11);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftchild);
            bst.Insert (rightChild);

            // Then
            Assert.Equal (3, bst.GetSize ());
            Assert.Equal (root, bst.GetRoot ().GetRightChild ().GetParent ());
        }

        [Fact]
        public void MinimumNodeIsProperlyReturned () {
            TreeNode root = new TreeNode (10);
            TreeNode leftchild = new TreeNode (5);
            TreeNode rightChild = new TreeNode (11);
            TreeNode minimum = new TreeNode (-500);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftchild);
            bst.Insert (rightChild);
            bst.Insert (minimum);

            // Then
            Assert.Equal (minimum, bst.Minimum ());
        }

        [Fact]
        public void NoLeftBranchRootNodeIsMinimum () {
            TreeNode root = new TreeNode (10);
            TreeNode rightChild = new TreeNode (11);
            TreeNode maximum = new TreeNode (100);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (rightChild);
            bst.Insert (maximum);

            // Then
            Assert.Equal (root, bst.Minimum ());
        }

        [Fact]
        public void MaximumNodeIsProperlyReturned () {
            TreeNode root = new TreeNode (10);
            TreeNode leftchild = new TreeNode (5);
            TreeNode rightChild = new TreeNode (11);
            TreeNode maximum = new TreeNode (500);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftchild);
            bst.Insert (rightChild);
            bst.Insert (maximum);

            // Then
            Assert.Equal (maximum, bst.Maximum ());
        }

        [Fact]
        public void NoRightBranchRootNodeIsMaximum () {
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (-11);
            TreeNode minimum = new TreeNode (-100);

            // Given
            Assert.Null (bst.GetRoot ());

            // When
            bst.Insert (root);
            bst.Insert (leftChild);
            bst.Insert (minimum);

            // Then
            Assert.Equal (root, bst.Maximum ());
        }

        [Fact]
        public void NodeIsNotInTreeReturnNullSearch () {
            // Given
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (-11);
            TreeNode minimum = new TreeNode (-100);

            // When 

            // Then
            Assert.Null (bst.Search (-10));
        }

        [Fact]
        public void NodeIsInTreeReturnCorrectSearch () {
            //Given
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (-11);
            TreeNode minimum = new TreeNode (-100);

            //When
            bst.Insert (root);
            bst.Insert (leftChild);
            bst.Insert (minimum);

            //Then
            Assert.Equal (leftChild, bst.Search (-11));
        }

        [Fact]
        public void PreOrderTraversalReturnsCorrectOrder () {
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (20);
            TreeNode minimum = new TreeNode (-100);
            List<int> traversal = new List<int>();
            traversal.Add(10);
            traversal.Add(-100);
            traversal.Add(20);
            bst.Insert (root);
            bst.Insert (leftChild);
            bst.Insert (minimum);

            //When
            bst.PreOrderTraversal();

            //Then
            Assert.Equal(traversal, bst.GetPreOrderList());
        }

        [Fact]
        public void InOrderTraversalReturnsCorrectOrder () {
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (20);
            TreeNode minimum = new TreeNode (-100);
            List<int> traversal = new List<int>();
            traversal.Add(-100);
            traversal.Add(10);
            traversal.Add(20);
            bst.Insert (root);
            bst.Insert (leftChild);
            bst.Insert (minimum);

            //When
            bst.InOrderTraversal();

            //Then
            Assert.Equal(traversal, bst.GetInOrderList());
        }

        [Fact]
        public void PostOrderTraversalReturnsCorrectOrder () {
            TreeNode root = new TreeNode (10);
            TreeNode leftChild = new TreeNode (20);
            TreeNode minimum = new TreeNode (-100);
            List<int> traversal = new List<int>();
            traversal.Add(-100);
            traversal.Add(20);
            traversal.Add(10);
            bst.Insert (root);
            bst.Insert (leftChild);
            bst.Insert (minimum);

            //When
            bst.PostOrderTraversal();

            //Then
            Assert.Equal(traversal, bst.GetPostOrderList());
        }

        [Fact]
        public void TestBstInOrderTraversal () {
            int[] input = { 20, 99, -1, 40, -70, 1000, -491, 27, 88 };

        }
        #endregion
    }
}