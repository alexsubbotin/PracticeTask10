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
    }
}
