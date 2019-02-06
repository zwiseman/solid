namespace solidproj {
    public class BinarySearchTree {

        #region Class Variables
        TreeNode root;
        int size;
        #endregion

        #region Constructor
        public BinarySearchTree () {
            root = null;
            size = 0;
        }
        #endregion

        #region Getters
        public int GetSize () {
            return this.size;
        }

        public TreeNode GetRoot () {
            return this.root;
        }
        #endregion

        #region Class Methods
        public TreeNode Insert (TreeNode newNode) {
            TreeNode tempRoot = null;
            TreeNode root = this.root;

            while (root != null) {
                tempRoot = root;
                if (newNode.GetKey() < tempRoot.GetKey()) {
                    root = root.GetLeftChild();
                } else {
                    root = root.GetRightChild();
                }
            }

            newNode.SetParent(tempRoot);

            if (tempRoot == null) {
                this.root = newNode;
                size++;
            } else if (newNode.GetKey() < tempRoot.GetKey()) {
                tempRoot.SetLeftChild(newNode);
                size++;
            } else {
                tempRoot.SetRightChild(newNode);
                size++;
            }
            return newNode;
        }

        public TreeNode Search (int key) {
            return Search (root, key);
        }

        private TreeNode Search (TreeNode node, int key) {
            return node;
        }

        public TreeNode Minimum () {
            return Minimum (root);
        }

        private TreeNode Minimum (TreeNode root) {
            while(root.GetLeftChild() != null) {
                root = root.GetLeftChild();
            }
            return root;
        }

        public TreeNode Maximum () {
            return Maximum (root);
        }

        private TreeNode Maximum (TreeNode root) {
            while(root.GetRightChild() != null) {
                root = root.GetRightChild();
            }
            return root;
        }

        public void PreOrderTraversal () {
            PreOrderTraversal(root);
        }

        private void PreOrderTraversal (TreeNode root) {
        }

        public void InOrderTraversal () {
            PreOrderTraversal(root);
        }

        private void InOrderTraversal (TreeNode root) {

        }

        public void PostOrderTraversal () {
            PostOrderTraversal(root);
        }

        private void PostOrderTraversal (TreeNode root) {

        }

        #endregion
    }
}