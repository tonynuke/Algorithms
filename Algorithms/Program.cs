using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Program
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public static void Run()
    {
        var tree = new TreeNode<int>
        {
            Value = 1,
            Children = new List<TreeNode<int>> {
                    new TreeNode<int>
                    {
                        Value = 2,
                        Children = new List<TreeNode<int>>
                        {
                            new TreeNode<int> { Value = 3 },
                            new TreeNode<int> { Value = 4 },
                        }
                    },
                    new TreeNode<int>
                    {
                        Value = 5,
                        Children = new List<TreeNode<int>>
                        {
                            new TreeNode<int> { Value = 6 },
                        }
                    }
                }
        };

        Console.WriteLine(string.Join(",", Tree.Traverse(tree)));
    }

    static async Task<int> IBD(int x)
    {
        await Task.Delay(x);
        return x;
    }

    public static async Task Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = "world";
        string s3 = "Hello world";

        var eq = s1 + s2 == s3;

        var task = await Tasks.MyWhenAny<int>(new Task<int>[]
        {
                IBD(10), IBD(20), IBD(30), IBD(5)
        });

        var z = task.Result;

        var x = new Point { X = 4, Y = 6 };
        var y = new Point { X = 4, Y = 6 };

        var b1 = x == y;
        var b2 = x.Equals(y);

        Run();

        var xs = new[] { -7, -5, 0, 5, 6 };
        var squares = xs.Select(x => x * x).OrderBy(x => x);

        var sorted = Tasks.BubbleSort(xs);

        var reversed = Tasks.Reverse(xs);
        var sortedSquares = Tasks.SquareAndSort(xs);

        var time2 = Tasks.CalculateWashTime(2, new[] { 5, 1, 5 });
    }
}