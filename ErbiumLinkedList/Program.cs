﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree list = new BinarySearchTree();

            Node node1 = new Node(6);
            Node node2 = new Node(5);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(7);
            Node node6 = new Node(8);
            Node node7 = new Node(6);
            list.AddNode(node1);
            list.AddNode(node2);
            list.AddNode(node3);
            list.AddNode(node4);
            list.AddNode(node5);
            list.AddNode(node6);
            list.AddNode(node7);

            list.Search(node5);

            Console.WriteLine();
            Console.ReadLine();

         
        }
    }
}
