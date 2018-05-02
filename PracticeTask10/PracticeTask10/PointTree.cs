using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask10
{
    // Class for elements of a tree.
    class PointTree
    {
        // Value.
        public int Value { get; set; }

        // Next element on the left.
        public PointTree Left { get; set; }

        // Next element on the right.
        public PointTree Right { get; set; }

        // Constructor with parameters.
        public PointTree(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
}
