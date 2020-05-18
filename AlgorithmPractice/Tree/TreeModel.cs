using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    public class TreeNode<T>
    {
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public T Data { get; private set; }

        public TreeNode(T data)
        {
            Data = data;
        }
    }

    public abstract class Tree<T>
    {
        protected TreeNode<T> Root { get; set; }

        public List<T> TraversedNodes { get; protected set; } = new List<T>();

        public abstract void Insert(TreeNode<T> node);

        public abstract void Delete(TreeNode<T> node);

        public abstract void Search();

        public abstract IList<T> Traverse();
    }

    public class BinaryTree<T> : Tree<T>
    {
        private readonly ITraversal<T> _TraversalStrategy;

        public BinaryTree(TreeNode<T> data,ITraversal<T> traversalStrategy)
        {
            Root = data;
            _TraversalStrategy = traversalStrategy;
            TraversedNodes = new List<T>();
        }

        public override void Delete(TreeNode<T> node)
        {

        }

        public override void Insert(TreeNode<T> node)
        {

        }

        public override void Search()
        {

        }

        public override IList<T> Traverse()
        {
            return _TraversalStrategy.Traverse(Root);
        }
    }
}
