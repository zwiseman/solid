namespace solidproj
{
    public class TreeNode
    {
        #region Class Variables
        int key;
        TreeNode parent;
        TreeNode leftChild;
        TreeNode rightChild;
        #endregion

        #region Constructor
        public TreeNode (int key) {
            this.key = key;
            parent = null;
            leftChild = null;
            rightChild = null;
        }
        #endregion

        #region Getters
        public int GetKey() {
            return key;
        }

        public TreeNode GetParent() {
            return parent;
        }

        public TreeNode GetLeftChild() {
            return leftChild;
        }

        public TreeNode GetRightChild() {
            return rightChild;
        }
        #endregion

        #region Setters
        public void SetParent(TreeNode parent) {
            this.parent = parent;
        }

        public void SetLeftChild(TreeNode leftChild) {
            this.leftChild = leftChild;
        }

        public void SetRightChild(TreeNode rightChild) {
            this.rightChild = rightChild;
        }
        #endregion
    }
}