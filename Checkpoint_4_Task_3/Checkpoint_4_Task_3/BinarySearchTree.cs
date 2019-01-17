using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_4_Task_3
{
    class BinarySearchTree
    {
        public Node root, current;


        public BinarySearchTree()
        {
            this.root = null;
        }

        public void AddNode(string a)
        {
            Node newNode = new Node(a);
            if (root == null)

                root = newNode;
            else
            {
                Node previous;
                current = root;

                while (current != null)
                {
                    previous = current;

                    if (a.CompareTo(current.data) < 0)
                    {
                        current = current.left;

                        if (current == null)
                            previous.left = newNode;
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                            previous.right = newNode;
                    }
                }
            }
        }
        public Node FindNode(IComparable value)
        {
            Node node = findValueNode(this.root, value);
            if (node == null)
            {
                Console.WriteLine("value not found");
                return null;
            }
            else
            {
                return findValueNode(this.root, value);
            }
        }

        private Node findValueNode(Node node, IComparable value)
        {
            if (node == null)
            {
                return null;
            }

            int search = value.CompareTo(node.data);
            Console.WriteLine("current node data is {0}", node.data);
            if (search == 0)
            {
                return node;
            }

            if (search < 0)
            {
                return findValueNode(node.left, value);
            }

            else if (search > 0)
            {

                return findValueNode(node.right, value);
            }
            else
            {
                return node;
            }
        }
        static String Output = "";
        public string PrintNodes(Node root)
        {
           if (root != null)
            {
                PrintNodes(root.left);
                Output += root.data + "\r\n";
                PrintNodes(root.right);
            }
            return Output;
            }
        }   
    }
            
            
            
            
            
           
  


       
