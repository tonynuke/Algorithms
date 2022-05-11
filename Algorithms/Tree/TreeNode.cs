using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public sealed class TreeNode<TValue>
    {
        public List<TreeNode<TValue>> Children { get; set; } = new List<TreeNode<TValue>>();

        public TValue Value { get; set; }

        public bool HasChildren => Children.Any();
    }
}
