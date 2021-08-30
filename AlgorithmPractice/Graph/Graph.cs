using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Graph
{
    public class Graph<T> where T:GraphModel
    {
        public LinkedList<T>[] Matrix { get; }
        public int NoOfVertices { get; }

        private readonly IGraphTraversal<T> _TraversalStratgy;
        public Graph(int vertices, IGraphTraversal<T> traversalStratgy)
        {
            _TraversalStratgy = traversalStratgy;
            this.NoOfVertices= vertices;
            Matrix = new LinkedList<T>[NoOfVertices];
            for (int i = 0; i < Matrix.Length; i++)
            {
                Matrix[i] = new LinkedList<T>();
            }
        }

        public void AddEdge(T v, T w)
        {
            Matrix[v.Id].AddLast(w);
        }

        public List<T> Traverese(T SOurceVertex)
        {
           return _TraversalStratgy.Traverse(Matrix, SOurceVertex);
        }
    }

    public class GraphModel
    {
        public int Id { get; set; }
    }

    public interface IGraphTraversal<T> where T : GraphModel
    {
        List<T> Traverse(LinkedList<T>[] input,T sourceVertex) ;
    }

    public class DepthFirstSearchTraversal<T> : IGraphTraversal<T> where T:GraphModel
    {
        public List<T> Traverse(LinkedList<T>[] input,T source)
        {           
            var length = input.Length;
            var visted = new bool[length];
            bool hasCycle = false;
            var recStack = new bool[length];
            List<T> output = new List<T>();
            Stack<T> stack = new Stack<T>();
            recStack[source.Id] = true;
            visted[source.Id] = true;
            stack.Push(source);            
            while (stack.Count>0)
            {
                var popedItem = stack.Pop();

                if(visted[popedItem.Id]==false)
                {
                    output.Add(popedItem);
                    visted[popedItem.Id] = true;
                }

                foreach (var v in input[popedItem.Id])
                {
                    if (!visted[v.Id])
                    {
                        stack.Push(v);
                    }
                    else if(visted[v.Id]==true)
                    {

                    }
                }             
            }
            return output;           
            
        }
    }
}
