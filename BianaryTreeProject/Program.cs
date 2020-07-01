﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianaryTreeProject
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();


            binaryTree.Add(3);
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(5);
            binaryTree.Add(6);
            binaryTree.Add(2);
            binaryTree.Add(9);



            binaryTree.Search(8);
            binaryTree.Search(5);
            binaryTree.Search(7);
            binaryTree.Search(3);
            binaryTree.Search(2);
            binaryTree.Search(9);
            binaryTree.Search(6);
        }
    }
}
