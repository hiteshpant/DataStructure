using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    public interface ITraversal<T>
    {
        IList<T> Traverse(TreeNode<T> tree);
    }

    //LNR->Left Node Right
    //In case of binary serach tree it will display data in descreasing order
    public class InorderTraversal<T> : ITraversal<T>
    {
        private List<T> _TravesredNodes = new List<T>();

        //public IList<T> Traverse(TreeNode<T> tree)
        //{
        //    if (tree == null)
        //    {
        //        return _TravesredNodes;
        //    }
        //    Traverse(tree.Left);
        //    _TravesredNodes.Add(tree.Data);
        //    Traverse(tree.Right);
        //    return _TravesredNodes;
        //}

        public IList<T> Traverse(TreeNode<T> tree)
        {
            var currentNode = tree;
            Stack<TreeNode<T>> _Stack = new Stack<TreeNode<T>>();
            while (currentNode != null || _Stack.Count > 0)
            {
                if (currentNode != null)
                    _Stack.Push(currentNode);
                currentNode = currentNode?.Left;
                if (currentNode == null && _Stack.Count() > 0)
                {
                    var popedItem = _Stack.Pop();
                    _TravesredNodes.Add(popedItem.Data);
                    currentNode = popedItem.Right;
                }
            }
            return _TravesredNodes;
        }
    }

    //NLR -> Node Left Right
    //Preorder traversal is also useful to get the prefix
    //expression of an expression tree
    public class PreorderTraversal<T> : ITraversal<T>
    {
        private IList<T> _TravesredNodes = new List<T>();

        //public IList<T> Traverse(TreeNode<T> tree)
        //{
        //    if (tree == null)
        //    {
        //        return _TravesredNodes;
        //    }
        //    _TravesredNodes.Add(tree.Data);
        //    Traverse(tree.Left);
        //    Traverse(tree.Right);
        //    return _TravesredNodes;
        //}

        public IList<T> Traverse(TreeNode<T> tree)
        {
            var currentNode = tree;
            Stack<TreeNode<T>> _Stack = new Stack<TreeNode<T>>();
            while (currentNode != null || _Stack.Count > 0)
            {
                if (currentNode != null)
                {
                    _TravesredNodes.Add(currentNode.Data);
                    _Stack.Push(currentNode);
                }
                currentNode = currentNode?.Left;
                if (currentNode == null && _Stack.Count() > 0)
                {
                    var poppedItem = _Stack.Pop();
                    currentNode = poppedItem.Right;
                }
            }
            return _TravesredNodes;
        }

    }

    //LRN->Left Right Node
    //Postorder traversal is also useful to get the
    //postfix expression of an expression tree
    public class PostOrderTraversal<T> : ITraversal<T>
    {
        private IList<T> _TravesredNodes = new List<T>();

        /// <summary>
        /// Recursive Method
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        //public IList<T> Traverse(TreeNode<T> tree)
        //{
        //    if (tree == null)
        //    {
        //        return _TravesredNodes;
        //    }
        //    Traverse(tree.Left);
        //    Traverse(tree.Right);
        //    _TravesredNodes.Add(tree.Data);
        //    return _TravesredNodes;
        //}     

        //Non Recursice method
        public IList<T> Traverse(TreeNode<T> tree)
        {
            var currentNode = tree;
            Stack<TreeNode<T>> _Stack1 = new Stack<TreeNode<T>>();
            Stack<TreeNode<T>> _Stack2 = new Stack<TreeNode<T>>();

            _Stack1.Push(tree);
            while (_Stack1.Count > 0)
            {
                var popedItem = _Stack1.Pop();
                _Stack2.Push(popedItem);
                if (popedItem.Left != null)
                    _Stack1.Push(popedItem?.Left);
                if (popedItem.Right != null)
                    _Stack1.Push(popedItem?.Right);

            }
            _Stack1.ToList().ForEach(x => _TravesredNodes.Add(x.Data));
            return _TravesredNodes;
        }    
    }

    public class LevelOrderTraversal<T> : ITraversal<T>
    {
        private List<T> _TravesredNodes = new List<T>();

        public IList<T> Traverse(TreeNode<T> tree)
        {

            Queue<TreeNode<T>> _Visited = new Queue<TreeNode<T>>();

            _Visited.Enqueue(tree);
            while (_Visited.Count > 0)
            {
                var nextItem = _Visited.Dequeue();
                _TravesredNodes.Add(nextItem.Data);

                var leftChild = nextItem?.Left;
                var rightChild = nextItem?.Right;

                if (leftChild != null)
                    _Visited.Enqueue(leftChild);

                if (rightChild != null)
                    _Visited.Enqueue(rightChild);
            }

            return _TravesredNodes;
        }
    }
}
