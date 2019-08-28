using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightOfBinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    class BinaryTree
    {
        public Node root;

        public int HeightOfBInaryTree(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = HeightOfBInaryTree(node.left);
            int right = HeightOfBInaryTree(node.right);

            if (left > right)
            {
                return 1 + left;
            }
            else
            {
                return 1 + right;
            }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Height of Binary Tree is : {0}", tree.HeightOfBInaryTree(tree.root));
            Console.ReadKey();
        }
    }
}
