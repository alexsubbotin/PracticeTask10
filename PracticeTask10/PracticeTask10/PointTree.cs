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

        // Next element of the right.
        public PointTree Right { get; set; }
    }
}
