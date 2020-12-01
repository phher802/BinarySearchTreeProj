using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumLinkedList
{
    class Node
    {
        public int data;
        public Node NextNode;

        public Node(int data)
        {
            this.data = data;
            NextNode = null;
        }
    }
}
