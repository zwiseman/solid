namespace solidproj
{
    public class Node
    {
        public int node {get; set;}
        public int parent {get; set;}
        public Node(int node, int parent) {
            this.node = node;
            this.parent = parent;
        }
    }
}