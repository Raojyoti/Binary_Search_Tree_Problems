using System;

namespace UC_1_Create_a_BST
{
    public class Program
    {
        static void Main(string[] args)
        {
            BSTTree tree = new BSTTree();
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.Display(tree.ReturnRoot());
        }
    }
}
