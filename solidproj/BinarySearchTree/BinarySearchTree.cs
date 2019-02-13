using System;
using System.Collections.Generic;

namespace solidproj {
    public class BinarySearchTree : IBinarySearchTree<TreeNode> {

        #region Class Variables
        TreeNode root;
        int size;
        List<int> binarySearchTree = new List<int>();
        List<int> preOrder = new List<int> ();
        List<int> inOrder = new List<int> ();
        List<int> postOrder = new List<int> ();
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

        public List<int> GetBinarySearchTree() {
            return binarySearchTree;
        }

        public List<int> GetPreOrderList () {
            return preOrder;
        }

        public List<int> GetInOrderList () {
            return inOrder;
        }

        public List<int> GetPostOrderList () {
            return postOrder;
        }
        #endregion

        #region Class Methods
        /**
         * Insert function to handle inserts into the BST.
         */
        public TreeNode Insert (TreeNode newNode) {
            TreeNode tempRoot = null;
            TreeNode root = this.root;

            while (root != null) {
                tempRoot = root;
                if (newNode.GetKey () < tempRoot.GetKey ()) {
                    root = root.GetLeftChild ();
                } else {
                    root = root.GetRightChild ();
                }
            }

            newNode.SetParent (tempRoot);

            if (tempRoot == null) {
                this.root = newNode;
                size++;
            } else if (newNode.GetKey () < tempRoot.GetKey ()) {
                tempRoot.SetLeftChild (newNode);
                size++;
            } else {
                tempRoot.SetRightChild (newNode);
                size++;
            }
            binarySearchTree.Add(newNode.GetKey());
            return newNode;
        }

        public TreeNode Search (int key) {
            return Search (root, key);
        }

        private TreeNode Search (TreeNode node, int key) {
            if (node == null) {
                return null;
            }

            if (node.GetKey () == key) {
                return node;
            }

            if (key < node.GetKey ()) {
                return Search (node.GetLeftChild (), key);
            } else {
                return Search (node.GetRightChild (), key);
            }
        }

        /**
         * Return the minimum key value node in the tree.
         */
        public TreeNode Minimum () {
            return Minimum (root);
        }

        private TreeNode Minimum (TreeNode root) {
            while (root.GetLeftChild () != null) {
                root = root.GetLeftChild ();
            }
            return root;
        }

        /**
         * Return the maximum key value in the tree.
         */
        public TreeNode Maximum () {
            return Maximum (root);
        }

        private TreeNode Maximum (TreeNode root) {
            while (root.GetRightChild () != null) {
                root = root.GetRightChild ();
            }
            return root;
        }

        public void PreOrderTraversal () {
            PreOrderTraversal (root);
        }

        private void PreOrderTraversal (TreeNode root) {
            if (root != null) {
                preOrder.Add (root.GetKey ());
                PreOrderTraversal (root.GetLeftChild ());
                PreOrderTraversal (root.GetRightChild ());
            }
        }

        public void InOrderTraversal () {
            InOrderTraversal (root);
        }

        private void InOrderTraversal (TreeNode root) {
            if (root != null) {
                InOrderTraversal (root.GetLeftChild ());
                inOrder.Add (root.GetKey ());
                InOrderTraversal (root.GetRightChild ());
            }
        }

        public void PostOrderTraversal () {
            PostOrderTraversal (root);
        }

        private void PostOrderTraversal (TreeNode root) {
            if (root != null) {
                PostOrderTraversal(root.GetLeftChild());
                PostOrderTraversal(root.GetRightChild());
                postOrder.Add(root.GetKey());
            }
        }

        #endregion
    }
}