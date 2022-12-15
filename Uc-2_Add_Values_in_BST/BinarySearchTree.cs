using System;
using System.Collections.Generic;
using System.Text;

namespace Uc_2_Add_Values_in_BST
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node node = new Node(id);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = node;
                            return;
                        }
                    }
                }

            }
        }
        public void Display(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.item + " | ");
                Display(root.leftc);
                Display(root.rightc);
            }
        }


        public virtual int size()
        {
            return size(root);
        }

        public int size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.leftc) + 1 + size(node.rightc));
            }
        }
    }
}
