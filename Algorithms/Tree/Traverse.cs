using System.Collections.Generic;

namespace Algorithms
{
    public static partial class Tree
    {
        public static IEnumerable<TValue> Traverse<TValue>(TreeNode<TValue> node)
        {
            var accumulator = new List<TValue>();

            Traverse(node, accumulator);
            return accumulator;

            static void Traverse<TValue>(TreeNode<TValue> node, List<TValue> accumulator)
            {
                accumulator.Add(node.Value);

                if (!node.HasChildren)
                {
                    return;
                }

                foreach (var child in node.Children)
                {
                    Traverse(child, accumulator);
                }
            }
        }
    }
}
