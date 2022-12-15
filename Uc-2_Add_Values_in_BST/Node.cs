using System;
using System.Collections.Generic;
using System.Text;

namespace Uc_2_Add_Values_in_BST
{
    public class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
        public int data;
        public Node(int data)
        {
            item = data;
            leftc = null;
            rightc = null;
        }
    }
}
