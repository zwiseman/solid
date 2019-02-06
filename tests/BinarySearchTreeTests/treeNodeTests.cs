using solidproj;
using Xunit;

namespace tests {
    public class treeNodeTests {

        #region Class Variables
        TreeNode parent = new TreeNode (1);
        TreeNode rightChild = new TreeNode (2);
        TreeNode leftChild = new TreeNode (3);
        #endregion
        
        #region Tests
        [Fact]
        public void ParentKeyIsCorrect () {
            //Given
            Assert.NotNull (parent);

            //When
            Assert.NotEqual (0, parent.GetKey ());

            //Then
            Assert.Equal (1, parent.GetKey ());
        }

        [Fact]
        public void ParentHasRightChildWhenAssigned () {
            //Given
            Assert.Null (parent.GetRightChild ());

            //When
            parent.SetRightChild (rightChild);

            //Then
            Assert.Equal (rightChild, parent.GetRightChild ());
        }

        [Fact]
        public void ParentHasLeftChildWhenAssigned () {
            //Given
            Assert.Null (parent.GetLeftChild ());

            //When
            parent.SetLeftChild (leftChild);

            //Then
            Assert.Equal (leftChild, parent.GetLeftChild ());
        }

        [Fact]
        public void ParentHasTwoChildrenWhenAssigned () {
            //Given
            Assert.Null (parent.GetLeftChild ());
            Assert.Null (parent.GetRightChild ());

            //When
            parent.SetLeftChild (leftChild);
            parent.SetRightChild (rightChild);

            //Then
            Assert.Equal (leftChild, parent.GetLeftChild ());
            Assert.Equal (rightChild, parent.GetRightChild ());
        }

        [Fact]
        public void ParentHasChildrenThenAllKeysAreCorrect () {
            //Given
            Assert.Null(parent.GetRightChild());
            Assert.Null(parent.GetLeftChild());

            //When
            parent.SetRightChild(rightChild);
            parent.SetLeftChild(leftChild);

            //Then
            Assert.Equal(2, parent.GetRightChild().GetKey());
            Assert.Equal(3, parent.GetLeftChild().GetKey());
        }
        #endregion
    }
}