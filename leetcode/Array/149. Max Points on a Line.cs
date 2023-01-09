using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
	class Program149
	{
		public static void Main_149(string[] args)
		{
			var s = new _149();

            Assert.AreEqual(3, s.MaxPoints(new int[][] {
                new int[] {3, 3},
                new int[] {1, 4},
                new int[] {1, 1},
                new int[] {2, 1},
                new int[] {2, 2},
            }));
            Assert.AreEqual(5, s.MaxPoints(new int[][] {
                new int[] {0, 0},
                new int[] {4, 5},
                new int[] {7, 8},
                new int[] {8, 9},
                new int[] {5, 6},
                new int[] {3, 4},
                new int[] {1, 1},
            }));
            Assert.AreEqual(3, s.MaxPoints(new int[][] {
                new int[] {4, 5},
                new int[] {4, -1},
                new int[] {4, 0}
            }));
            Assert.AreEqual(2, s.MaxPoints(new int[][] {
                new int[] {0, 0},
                new int[] {1, -1},
                new int[] {1, 1}
            }));
            Assert.AreEqual(4, s.MaxPoints(new int[][] {
                new int[] {1, 1},
                new int[] {3, 2},
                new int[] {5, 3},
                new int[] {4, 1},
                new int[] {2, 3},
                new int[] {1, 4},
            }));
            Assert.AreEqual(3, s.MaxPoints(new int[][] {
                new int[] {1, 1},
                new int[] {2, 2},
                new int[] {3, 3}
            }));
            Assert.AreEqual(1, s.MaxPoints(new int[][] {
                new int[] {1, 1}
            }));
        }
	}

	class _149
    {
		public int MaxPoints(int[][] points)
		{
            if (points.Length <= 2)
            {
				return points.Length;
            }

			var angles = new Dictionary<(double, double), HashSet<(int, int)>>();
			var maxPointsCount = 2;

            for (int i = 0; i < points.Length-1; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
					double xDiff = points[j][0] - points[i][0];
					double yDiff = points[j][1] - points[i][1];
					var angle = xDiff == 0 ? Double.PositiveInfinity : Math.Round(Math.Tan(yDiff / xDiff), 4);
					var b = xDiff == 0 ? points[j][0] :  points[j][1] - angle * points[j][0];
					
					if (!angles.ContainsKey((angle, b)))
					{
						angles.Add((angle, b), new HashSet<(int, int)> { (points[i][0], points[i][1]) });
						angles[(angle, b)].Add((points[j][0], points[j][1]));
						continue;
					}

					angles[(angle, b)].Add((points[i][0], points[i][1]));
					angles[(angle, b)].Add((points[j][0], points[j][1]));
					maxPointsCount = Math.Max(angles[(angle, b)].Count, maxPointsCount);
				}
			}

			return maxPointsCount;
		}

        public int MaxPoints1(int[][] points) {
            int n = points.Length;
            if (n == 1) {
                return 1;
            }
            int result = 2;
            for (int i = 0; i < n; i++) {
                //this is the line that solves the problem more elegantly comparing with decision above
                Dictionary<double, int> cnt = new ();
                for (int j = 0; j < n; j++) {
                    if (j != i) {
                        var atan2 = Math.Atan2(points[j][1] - points[i][1],
                    	    points[j][0] - points[i][0]);
                        if (cnt.ContainsKey(atan2))
                        {
                            cnt[atan2]++;
                        }
                        else
                        {
                            cnt.Add(atan2, 1);
                        }
                    }
                }
                result = Math.Max(result, cnt.Values.Max() + 1);
            }
            return result;
        }
	}
}
