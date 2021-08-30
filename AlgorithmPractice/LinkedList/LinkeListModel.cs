

namespace AlgorithmPractice.LinkedList
{
    public class Node<T>
    {
        public T Data { get; private set; }
     
        public Node<T> Next { get;  set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class DoublyNode<T>
    {
        public T Data { get; private set; }

        public DoublyNode<T> Next { get;  set; }

        public DoublyNode<T> Previous { get;  set; }

        public DoublyNode(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get;  set; }
    }

    public class DoublyLinkedList<T>
    {
        public DoublyNode<T> Head { get;  set; }
    }

}
