using AlgorithmPractice.Array;
using AlgorithmPractice.Tree;
using AlgorithmPractice.Tree.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTest
{
    [TestClass]
    public class TreeUnitTest
    {
        [TestMethod]
        public void TestInorderTraversal()
        {
            TreeNode<int> root = new TreeNode<int>(1);
            ITraversal<int> _traversal = new InorderTraversal<int>();
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);
            root.Left.Right = new TreeNode<int>(5);
            root.Left.Left = new TreeNode<int>(4);

            var binarytree = new BinaryTree<int>(root, _traversal);
            IList<int> expectedOutput = new List<int>(new List<int> { 4, 2, 5, 1, 3 });
            var output = binarytree.Traverse();
            CollectionAssert.Equals(expectedOutput, output);
        }

        [TestMethod]
        public void TestPreOrderTraversal()
        {
            TreeNode<int> root = new TreeNode<int>(1);
            ITraversal<int> _traversal = new PreorderTraversal<int>();
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);
            root.Right.Right = new TreeNode<int>(5);
            root.Right.Left = new TreeNode<int>(4);
            IList<int> expectedOutput = new List<int>(new List<int> { 1, 2, 3, 4, 5 });
            var binarytree = new BinaryTree<int>(root, _traversal);
            var output = binarytree.Traverse();

            CollectionAssert.Equals(expectedOutput, output);
        }
        [TestMethod]
        public void TestPostOrderTraversal()
        {
            TreeNode<int> root = new TreeNode<int>(1);
            ITraversal<int> _traversal = new PostOrderTraversal<int>();
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);
            root.Left.Right = new TreeNode<int>(5);
            root.Left.Left = new TreeNode<int>(4);
            IList<int> expectedOutput = new List<int>(new List<int> { 4, 5, 2, 3, 1 });

            var binarytree = new BinaryTree<int>(root, _traversal);
            var output = binarytree.Traverse();
            CollectionAssert.Equals(expectedOutput, output);
        }

        [TestMethod]
        public void TestLevelTraversal()
        {
            TreeNode<int> root = new TreeNode<int>(1);
            ITraversal<int> _traversal = new LevelOrderTraversal<int>();
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);
            root.Left.Right = new TreeNode<int>(5);
            root.Left.Left = new TreeNode<int>(4);
            IList<int> expectedOutput = new List<int>(new List<int> { 1, 2, 3, 4, 5 });

            var binarytree = new BinaryTree<int>(root, _traversal);
            var output = binarytree.Traverse();
            CollectionAssert.Equals(expectedOutput, output);
        }

        [TestMethod]
        public void TestDeserializeSerialize()
        {
            AlgorithmPractice.Tree.Problems.TreeNode node = new AlgorithmPractice.Tree.Problems.TreeNode(1);

            node.left = new AlgorithmPractice.Tree.Problems.TreeNode(2);
            node.right = new AlgorithmPractice.Tree.Problems.TreeNode(3);
            node.right.left = new AlgorithmPractice.Tree.Problems.TreeNode(4);

            node.right.right = new AlgorithmPractice.Tree.Problems.TreeNode(5);

            Codec cd = new Codec();
            var output = cd.Serialize(node);
            var deserializedNode = cd.Deserialize(output);

        }

        [TestMethod]
        public void ValidateBST()
        {
            AlgorithmPractice.Tree.Problems.TreeNode node = new AlgorithmPractice.Tree.Problems.TreeNode(0);

            node.left = new AlgorithmPractice.Tree.Problems.TreeNode(-1);

            validateBSTSol sol = new validateBSTSol();
            sol.IsValidBST(node);
        }

        [TestMethod]
        public void TestBinaryLevelOrderTraversal()
        {
            AlgorithmPractice.Tree.Problems.TreeNode node = new AlgorithmPractice.Tree.Problems.TreeNode(3);
            node.left = new AlgorithmPractice.Tree.Problems.TreeNode(9);
            node.left.left = new AlgorithmPractice.Tree.Problems.TreeNode(11);
            node.left.right = new AlgorithmPractice.Tree.Problems.TreeNode(12);
            node.right = new AlgorithmPractice.Tree.Problems.TreeNode(20);
            node.right.left = new AlgorithmPractice.Tree.Problems.TreeNode(15);
            node.right.right = new AlgorithmPractice.Tree.Problems.TreeNode(7);
            PrintLevelOrderSolution sol = new PrintLevelOrderSolution();
            var output = sol.LevelOrder(node);
        }


        [TestMethod]
        public void TestConnectedLevelOrderTraversal()
        {
            AlgorithmPractice.Tree.Problems.Node node = new AlgorithmPractice.Tree.Problems.Node(1);
            node.left = new AlgorithmPractice.Tree.Problems.Node(2);
            node.left.left = new AlgorithmPractice.Tree.Problems.Node(4);
            node.left.right = new AlgorithmPractice.Tree.Problems.Node(5);
            node.right = new AlgorithmPractice.Tree.Problems.Node(3);
            node.right.left = new AlgorithmPractice.Tree.Problems.Node(6);
            node.right.right = new AlgorithmPractice.Tree.Problems.Node(7);
            RightConnectLecelOrderSolution sol = new RightConnectLecelOrderSolution();
            var output = sol.Connect(node);
        }


        [TestMethod]
        public void RepeatingCharacterProblemTest()
        {
            RepeatingCharacterProblem prob = new RepeatingCharacterProblem();
            var result = prob.GetNonRepeatinCharFromStream(new StringBuilder( "geeksforgeeksandgeeksquizfor"));
        }

        [TestMethod]
        public void LCAUnitTest()

        {
            var sol = new LCABinaryTree();
            LCABinaryTree.TreeNode node = new LCABinaryTree.TreeNode(1);
            node.left = new LCABinaryTree.TreeNode(2);
            node.right = new LCABinaryTree.TreeNode(3);
            node.left.left = new LCABinaryTree.TreeNode(4);
            node.left.right = new LCABinaryTree.TreeNode(5);
            node.right.left = new LCABinaryTree.TreeNode(6);
            node.right.right = new LCABinaryTree.TreeNode(7);
            var result =sol.LowestCommonAncestor(node, new LCABinaryTree.TreeNode(4), new LCABinaryTree.TreeNode(5));
        }


        [TestMethod]
        public void TrieTest()
        {

            Trie trie = new Trie();

            trie.Insert("apple");
            trie.Search("apple");   // returns true
            trie.Search("app");     // returns false
            trie.StartsWith("app"); // returns true
            trie.Insert("app");
            trie.Insert("app");     // returns true


        }
    }
}
