namespace solidproj
{
    public interface IBinarySearchTree<TreeNode>
    {
        TreeNode GetRoot();
        TreeNode Insert(TreeNode newNode);
    }
}