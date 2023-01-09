using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Design
{
    public static class Program335
    {
        public static void Main_335(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Twitter {
        Dictionary<int, LinkedList<int>> UserTweetsDict { get; set; }
        Dictionary<int, List<int>> Followers { get; set; }

        public Twitter() {
            UserTweetsDict = new Dictionary<int, LinkedList<int>>();
            Followers = new Dictionary<int, List<int>>();
        }
    
        public void PostTweet(int userId, int tweetId) {
            if (!UserTweetsDict.ContainsKey(userId))
            {
                UserTweetsDict.Add(userId, new LinkedList<int>());
            }

            UserTweetsDict[userId].AddFirst(tweetId);
        }
    
        public IList<int> GetNewsFeed(int userId) {
            if (true)
            {

            }

            return UserTweetsDict[userId].ToList();
        }
    
        public void Follow(int followerId, int followeeId) {
            if (!Followers.ContainsKey(followeeId))
            {
                Followers.Add(followeeId, new List<int>());
            }

            Followers[followeeId].Add(followerId);
        }
    
        public void Unfollow(int followerId, int followeeId) {
            var nodeToRemove = Followers[followeeId].Find(f => f == followerId);
            Followers[followeeId].Remove(nodeToRemove);
        }
    }
}
