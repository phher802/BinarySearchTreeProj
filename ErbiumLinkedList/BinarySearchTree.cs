using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumLinkedList
{
    class MyLinkedList
    {

        public Node RootNode;
        public Node LastNode;

        public MyLinkedList()
        {

        }


        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                LastNode = nodeToAdd;
            }
            else
            {
                LastNode.NextNode = nodeToAdd;
                LastNode = LastNode.NextNode;
            }

            //if(RootNode == null)
            //{
            //    RootNode = nodeToAdd;
            //}
            //else
            //{
            //    Node currentNode = RootNode;

            //    while (true)
            //    {
            //        if (currentNode.NextNode == null)
            //        {
            //            currentNode.NextNode = nodeToAdd;
            //            break;
            //        }
            //        else
            //        {
            //            currentNode = currentNode.NextNode;
            //        }
            //    }

            //}
        }
    }
}
