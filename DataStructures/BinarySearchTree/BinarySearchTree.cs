using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public Node(int idata, int dData)
        {
            this.iData = idata;
            this.dData = dData;
        }
        public int iData;
        public int dData;
        public Node leftChild;
        public Node rightChild;

        public void Display()
        {
            Console.WriteLine($" [{iData} , {dData}]");
        }
    }
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int key, int value)
        {
            Node newNode = new Node(key,value);

            if(root == null)
            {
                root = newNode;
                return;
            }

            Node Parent = root;
            Node current = root;            

            while (current != null)
            {
                Parent = current;
                if (key > root.iData)
                {                    
                    current = current.rightChild;
                    if (current == null)
                    {
                        Parent.rightChild = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.leftChild;
                    if (current == null)
                    {
                        Parent.leftChild = newNode;
                        return;
                    }
                }
            }

         }

        public Node Find(int key)
        {
            if (root == null)
                return null;

            Node current = root;

            while(current != null)
            {
                if(current.iData == key)
                {
                    return current;
                }
                else if(key > current.iData)
                {
                    current = current.rightChild;
                }
                else
                {
                    current = current.leftChild;
                }
            }

            return null;
        }


        public void Display()
        {
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.leftChild);
                Console.WriteLine(node.iData);
                TraverseInOrder(node.rightChild);
            }
            
        }


        public bool Delete(int key)
        {
            Node delNode = root;
            Node parent = root;
            Boolean IsRightChild = true; ;

            while (delNode.iData != key)
            {
                parent = delNode;

                if(key < delNode.iData)
                {
                    delNode = delNode.leftChild;
                    IsRightChild = false;
                }
                else
                {
                    delNode = delNode.rightChild;
                }

                if (delNode == null)
                    return false; // key not found
            }

            //case when nodetoBeDeleted has no child

            if(delNode.leftChild == null && delNode.rightChild == null)
            {
                if (delNode == root)
                    root = null;

                if (IsRightChild)
                    parent.rightChild = null;
                else
                    parent.leftChild = null;                    
            }

            //when deletion node has one chile
            else if (delNode.rightChild != null)
            {
                if (delNode == root)
                    root = delNode.rightChild;

                if (IsRightChild)
                    parent.rightChild = delNode.rightChild;
                else
                    parent.leftChild = delNode.rightChild;

            } else if(delNode.leftChild != null)
            {
                if (delNode == root)
                    root = delNode.leftChild;

                if (IsRightChild)
                    parent.rightChild = delNode.leftChild;
                else
                    parent.leftChild = delNode.leftChild;
            }

            //casewhere deletion key has both left and right child

            return true;
        }

        public int FindMin()
        {
            if (root == null)
                throw new Exception("there should be atleast one data");

            Node current = root;
            Node minNode = root;

            while (current != null)
            {
                minNode = current;
                current = current.leftChild;
            }

            return minNode.iData;
        }

        public int FindMax()
        {
            if (root == null)
                throw new Exception("there should be atleast one data");

            Node current = root;
            Node maxNode = root;

            while (current != null)
            {
                maxNode = current;
                current = current.rightChild;
            }

            return maxNode.iData;
        }
    }
}
