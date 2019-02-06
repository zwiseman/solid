namespace solidproj {
    public class BinarySearchTree {

        #region Class Variables
        TreeNode root;
        int size;
        #endregion

        #region Constructor
        public BinarySearchTree() {
            root = null;
            size = 0;
        }
        #endregion

        #region Getters
        public int GetSize() {
            return this.size;
        }

        public TreeNode GetRoot() {
            return this.root;
        }
        #endregion

    }
}