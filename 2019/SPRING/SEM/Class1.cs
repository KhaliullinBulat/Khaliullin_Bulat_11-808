using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        public int Iterations = 0;

        public LinkedList<int> Sorted = new LinkedList<int>();

        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            if (top == null)
            {
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            Node currentnode = top;
            bool added = false;
            do
            {
                Iterations++;
                if (value < currentnode.value)
                {
                    if (currentnode.left == null)
                    {
                        Node NewNode = new Node(value);
                        currentnode.left = NewNode;
                        added = true;
                    }
                    else
                        currentnode = currentnode.left;
                }
                if (value >= currentnode.value)
                {
                    if (currentnode.right == null)
                    {
                        Node NewNode = new Node(value);
                        currentnode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.right;
                    }
                }
            } while (!added);
        }

        public void Sort(Node N)
        {
            if (N == null) { N = top; }
            if (N.left != null)
            {
                Sort(N.left);
                Sorted.AddLast(N.value);
            }
            else
            {
                Sorted.AddLast(N.value);
            }
            if (N.right != null)
            {
                Sort(N.right);
            }
        }

        public void Change (LinkedList<int> llist)
        {
            llist = Sorted;
        }

        public int[] ToArray ()
        {
            var a = new int[Sorted.Count];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Sorted.First();
                Sorted.RemoveFirst();
            }
            return a;
        }
    }
}
