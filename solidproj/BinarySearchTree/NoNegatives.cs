namespace solidproj
{
    public class NoNegatives : BinarySearchTree
    {
        public TreeNode RemoveNegativeInsertion(TreeNode node){
            if (node.GetKey() < 0) {
                return null;
            } else {
                return node;
            }
        }
    }
}