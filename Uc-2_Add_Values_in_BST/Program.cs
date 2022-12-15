using System;

namespace Uc_2_Add_Values_in_BST
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.root = new Node(56);
            tree.root.leftc = new Node(30);
            tree.root.rightc = new Node(70);
            tree.root.rightc.rightc = new Node(95);
            tree.root.rightc.leftc = new Node(60);
            tree.root.rightc.leftc.rightc = new Node(65);
            tree.root.rightc.leftc.rightc.rightc = new Node(67);
            tree.root.rightc.leftc.rightc.leftc = new Node(63);
            tree.root.leftc.leftc = new Node(22);
            tree.root.leftc.rightc = new Node(40);
            tree.root.leftc.leftc.leftc = new Node(11);
            tree.root.leftc.leftc.leftc.leftc = new Node(3);
            tree.root.leftc.leftc.leftc.rightc = new Node(16);

            Console.WriteLine("The size of binary tree is : " + tree.size());

            tree.Display(tree.ReturnRoot());
        }
    }
}
