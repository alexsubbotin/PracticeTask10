using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask10
{
    class Program
    {
        // Task: create a tree traversal method that counts the number of tiers and the number of elements on each of the tiers.
        // Student: Alexey Subbotin. Group: SE-17-1.
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.CreateRandomTree();
            tree.ShowTree(tree.Root, 0);

            tree.GetEachTierElementsCount();
            Console.WriteLine("Height: {0}", tree.Height);

            Console.WriteLine("Tiers counts: ");
            foreach (int c in tree.TiersCounts)
                Console.Write(c + " ");

            Console.ReadLine();
        }
    }
}
