using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Graph
{
    public class Solution
    {
        private List<Course> _courses;
        private List<int> _visitedCourses;
        private bool[] _visited;

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            _courses = new List<Course>();
            _visitedCourses = new List<int>();
            _visited = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                var course = new Course(i);
                var deps = prerequisites.ToList().Where(p => p[0] == i);
                foreach (var item in deps)
                {
                    course.Deps.Add(item[1]);
                }

                _courses.Add(course);
            }

            _courses = _courses.OrderBy(t => t.Deps.Count).ToList();

            while (_courses.Any(c => !c.IsVisited))
            {
                var possibleCourses = _courses.Where(t => !t.IsVisited &&
                    t.Deps.All(d => _visitedCourses.Contains(d)));

                if (possibleCourses.Count() == 0)
                {
                    return false;
                }

                foreach (var course in possibleCourses)
                {
                    course.IsVisited = true;
                    _visitedCourses.Add(course.Num);
                }
            }

            return true;
        }
    }

    public class Course
    {
        public int Num { get; set; }

        public List<int> Deps { get; set; } = new();

        public bool IsVisited { get; set; }

        public Course(int num)
        {
            Num = num;
        }
    }

    public static class Program210
    {
        public static void Main(string[] args)
        {
            var sln = new Solution();
            var res = sln.CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static void Main1(string[] args)
        {
            var sln = new Solution();
            var res = sln.CanFinish(2, new int[][] { new int[] { 1, 0 } });
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
