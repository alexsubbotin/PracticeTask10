using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask10
{
    // Class for the tree.
    class Tree
    {
        // Root.
        PointTree Root { get; set; }

        // Constructor with a parameter.
        public Tree(PointTree Root)
        {
            this.Root = Root;
        }


        // Creating random tree.
        public Random rnd = new Random();
        public void CreateRandomTree()
        {
            int size = rnd.Next(1, 30);

            this.Root = RandomTree(size);
        }
        private PointTree RandomTree(int size)
        {
            // Temporary object.
            PointTree root;

            // The number of elements in the left and in the right branches.
            int nl, nr;

            // If size=0 then it's the end of the tree.
            if (size == 0)
            {
                root = null;
                return root;
            }

            // Getting the sizes of branches.
            nl = size / 2;
            nr = size - nl - 1;

            // Creating a random value for the root.
            int d = rnd.Next(20, 51);
            root = new PointTree(d);

            // Building the branches.
            root.Left = RandomTree(nl);
            root.Right = RandomTree(nr);

            return root;
        }

        // Getting the height of the tree (number of tiers).
        public int GetHeight(PointTree root)
        {
            // Height of the left branch.
            int leftHeight = 0;

            // Height of the right branch.
            int rightHeight = 0;

            // Height of the tree.
            int height = 0;

            if (root != null)
            {
                // Calculating the left height.
                leftHeight = 1 + GetHeight(root.Left);

                // Calculating the right height.
                rightHeight = 1 + GetHeight(root.Right);

                // The biggest of heights is the height of the tree.
                if (leftHeight > rightHeight)
                    height = leftHeight;
                else
                    height = rightHeight;
            }

            return height;
        }
    }
}
