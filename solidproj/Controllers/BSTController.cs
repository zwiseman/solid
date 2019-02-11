using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace solidproj.Controllers {

    [Route ("solid/")]
    [ApiController]
    public class BSTController : ControllerBase {
        // GET solid/
        [HttpGet]
        public ActionResult<string> Get () {
            return "API is up and running!";
        }

        [HttpGet ("binarySearchTree")]
        public ActionResult<List<Node>> GetBst () {
            BinarySearchTree bst = new BinarySearchTree ();
            List<Node> nodes = new List<Node>();
            Node node;
            int parentValue = -999999999;
            TreeNode[] treeNodes = {
                new TreeNode (100),
                new TreeNode (70),
                new TreeNode (129),
                new TreeNode (-20),
                new TreeNode (400),
                new TreeNode (99),
                new TreeNode (-47),
                new TreeNode (30),
                new TreeNode (50),
                new TreeNode (110),
                new TreeNode (20),
                new TreeNode (-50),
                new TreeNode (200),
                new TreeNode (327),
                new TreeNode (199)
            };

            foreach (var treeNode in treeNodes) {
                int i = 0;
                bst.Insert(treeNode);

                if (treeNode.GetParent() != null) {
                    parentValue = treeNode.GetParent().GetKey();
                }

                node = new Node(treeNode.GetKey(), parentValue);
                nodes.Add(node);
                i++;
            }

            return nodes;
        }

        [HttpGet ("preOrderTraversal")]
        public ActionResult<List<int>> GetPreOrderTraversal () {
            BinarySearchTree bst = new BinarySearchTree ();
            TreeNode[] nodes = {
                new TreeNode (100),
                new TreeNode (70),
                new TreeNode (129),
                new TreeNode (-20),
                new TreeNode (400),
                new TreeNode (99),
                new TreeNode (-47),
                new TreeNode (30),
                new TreeNode (50),
                new TreeNode (401),
                new TreeNode (20)
            };

            // Insert nodes into tree.
            for (int i = 0; i < nodes.Length; i++) {
                bst.Insert (nodes[i]);
            }

            bst.PreOrderTraversal ();
            return bst.GetPreOrderList ();
        }

        [HttpGet ("inOrderTraversal")]
        public ActionResult<List<int>> GetInOrderTraversal () {
            BinarySearchTree bst = new BinarySearchTree ();
            TreeNode[] nodes = {
                new TreeNode (100),
                new TreeNode (70),
                new TreeNode (129),
                new TreeNode (-20),
                new TreeNode (400),
                new TreeNode (99),
                new TreeNode (-47),
                new TreeNode (30),
                new TreeNode (50),
                new TreeNode (401),
                new TreeNode (20)
            };

            // Insert nodes into tree.
            for (int i = 0; i < nodes.Length; i++) {
                bst.Insert (nodes[i]);
            }

            bst.InOrderTraversal ();
            return bst.GetInOrderList ();
        }

        [HttpGet ("postOrderTraversal")]
        public ActionResult<List<int>> GetPostOrderTraversal () {
            BinarySearchTree bst = new BinarySearchTree ();
            TreeNode[] nodes = {
                new TreeNode (100),
                new TreeNode (70),
                new TreeNode (129),
                new TreeNode (-20),
                new TreeNode (400),
                new TreeNode (99),
                new TreeNode (-47),
                new TreeNode (30),
                new TreeNode (50),
                new TreeNode (401),
                new TreeNode (20)
            };
            
            // Insert nodes into tree.
            for (int i = 0; i < nodes.Length; i++) {
                bst.Insert (nodes[i]);
            }

            bst.PostOrderTraversal ();
            return bst.GetPostOrderList ();
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        [HttpPost ("binarySearchTree")]
        public ActionResult<List<Node>> PostBinarySearchTree ([FromBody] string nodesFromBody) {
            int[] nodesToInt = nodesFromBody.Split (',').Select (n => Convert.ToInt32 (n)).ToArray ();
            BinarySearchTree bst = new BinarySearchTree();
            List<Node> nodes = new List<Node>();
            TreeNode temp;
            Node node;
            int parentValue = -999999999;

            foreach (var item in nodesToInt) {
                int i = 0;
                temp = new TreeNode(item);
                bst.Insert(temp);

                if (temp.GetParent() != null) {
                    parentValue = temp.GetParent().GetKey();
                }

                node = new Node(temp.GetKey(), parentValue);
                nodes.Add(node);
                i++;
            }

            return nodes;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}