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
        public PointTree Root { get; set; }

        // Size of the tree.
        public int Size { get; set; }

        // Tree height.
        public int Height { get; set; }

        // Tiers counts.
        public int[] TiersCounts { get; set; }

        // Constructor with a parameter.
        public Tree(PointTree Root)
        {
            this.Root = Root;
            this.Size = 0;
            this.Height = 0;
            this.TiersCounts = null;
        }

        // Constructor without parameters.
        public Tree()
        {
            this.Root = new PointTree();
            this.Size = 0;
            this.Height = 0;
            this.TiersCounts = null;
        }


        // Creating random tree.
        public Random rnd = new Random();
        public void CreateRandomTree()
        {
            int size = rnd.Next(1, 30);
            this.Size = size;

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

        public void GetEachTierElementsCount()
        {
            // The maximum number of tiers is the number of elements (supposing each elements takes one tier).
            int maximumNumberOfTiers = this.Size;

            // Creating the array of elements count of each tier.
            int[] counts = new int[maximumNumberOfTiers];

            // Counting the numbers of elements.
            GetCounts(this.Root, 0, ref counts);

            // The height of the tree.
            int height = 0; 

            // Getting the height (number of non-zero elements).
            for(int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                    height++;
                else
                    break;
            }

            // Rewriting the counts.
            this.TiersCounts = new int[height];
            for(int i = 0; i < height; i++)
            {
                this.TiersCounts[i] = counts[i];
            }

            this.Height = height;
            
        }

        private void GetCounts(PointTree root, int currentTier, ref int[] counts)
        {
            // The end of the branch.
            if(root == null)
            {
                return;
            }
            else
            {
                // Increasing the number of elements on the current tier.
                counts[currentTier]++;

                // Calculating the next tier.
                GetCounts(root.Left, currentTier + 1, ref counts);
                GetCounts(root.Right, currentTier + 1, ref counts);
            }
        }

        // Method to print the tree.
        public void ShowTree(PointTree root, int space)
        {
            if (root != null)
            {
                ShowTree(root.Left, space + 3);

                for (int i = 0; i < space; i++)
                    Console.Write(" ");

                Console.WriteLine(root.Value);

                ShowTree(root.Right, space + 3);
            }
        }
    }
}
