using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        // member variables (has a)
        public Node RootNode;
        public Node LastNode;
        public int value;
        public List<int> _nodes;
        //public Node left;
        //public Node right;

        //constructor (spawner)
        public BinarySearchTree()
        {
            List<int> _nodes = new List<int>();

            //Node node1 = new Node(1);
            //Node node2 = new Node(2);
            //Node node3 = new Node(3);
            //Node node4 = new Node(4);
            //Node node5 = new Node(5);
            //Node node6 = new Node(6);
            //Node node7 = new Node(7);
            //node1.AddNode(node1);
            //node2.AddNode(node2);
            //node3.AddNode(node3);
            //node4.AddNode(node4);
            //node5.AddNode(node5);
            //node6.AddNode(node6);
            //node7.AddNode(node7);
        }


        public Node AddNode(Node nodeToAdd)
        {
           
            //if (RootNode == null)
            //{
            //    RootNode = nodeToAdd;
               
            //}
            //else if (nodeToAdd.data <= RootNode.data)
            //{

            //    LastNode.LeftNode = nodeToAdd;
               

            //}
            //else if (nodeToAdd.data > RootNode.data)
            //{
            //    LastNode.RightNode = nodeToAdd;
            //    //LastNode = LastNode.RightNode;
            //}

            //return LastNode;

            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = RootNode;

                while (nodeToAdd.data <= currentNode.data)

                    if (currentNode.LeftNode == null)
                    {
                        currentNode.LeftNode = nodeToAdd;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.LeftNode;
                    }

                while (nodeToAdd.data > currentNode.data)

                    if (currentNode.RightNode == null)
                    {
                        currentNode.RightNode = nodeToAdd;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                    }

            }
        }

        public void Search(Node value)
        {
            //this.value = value;
            //bool isFound = true;

            if (value == null)
            {
                return;
            }

            Search(value.LeftNode);
            Search(value.RightNode);

        }


    }
}
