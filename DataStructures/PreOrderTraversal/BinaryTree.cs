using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreOrderTraversal
{
    public class Node
    {
        public int iData;
        public Node LeftChild;
        public Node RightChild;

        public Node(int iData)
        {
            this.iData = iData;
            LeftChild = null;
            RightChild = null;
        }

        public void DisplayNode()
        {
            Console.WriteLine(iData);
        }
    }
    public class BinaryTree
    {
        Node root;

        public void insert(int iData)
        {
            Node newNode = new Node(iData);
            if (root == null)
            {
                root = newNode;
                return;
            }

            Node currentNode = root;
            Node parenNode = root;

            while (true)
            {
                parenNode = currentNode;

                if (iData > currentNode.iData)
                {
                    currentNode = currentNode.RightChild;
                    if (currentNode == null)
                    {
                        parenNode.RightChild = newNode;
                        return;
                    }
                }

                else
                {
                    currentNode = currentNode.LeftChild;
                    if (currentNode == null)
                    {
                        parenNode.LeftChild = newNode;
                        return;
                    }
                }
            }
        }

        public void DisplayInorder()
        {
            DisplayTreeInOrder(root);
        }

        public void DisplayTreeInOrder(Node root)
        {
            if (root == null)
                return;

            DisplayTreeInOrder(root.LeftChild);
            root.DisplayNode();
            DisplayTreeInOrder(root.RightChild);
        }

        private void DisplayPreOrderImplementation(Node root)
        {
            if (root == null)
                return;

            root.DisplayNode();
            DisplayPreOrderImplementation(root.LeftChild);
            DisplayPreOrderImplementation(root.RightChild);
        }

        public void DisplayPreOder()
        {
            DisplayPreOrderImplementation(root);
        }

        public void DisplayPreOrderWithoutRecursion()
        {

        }

        private void PreOrderWithourRecursionImplementatin(Node root)
        {
            Node currentRoot = root;
            Stack<Node> preorder = new Stack<Node>();

            preorder.Push(


 
        }
    }
}
