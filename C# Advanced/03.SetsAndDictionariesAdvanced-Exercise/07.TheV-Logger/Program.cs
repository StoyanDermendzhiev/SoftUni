using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<VloggerStats> vloggers = new List<VloggerStats>();

            while (input != "Statistics")
            {
                string[] vloggerInfo = input.Split();
                string currentVloggerName = vloggerInfo[0];
                string command = vloggerInfo[1];

                bool isVloggerExist = vloggers.Exists(v => v.VloggerName == currentVloggerName);

                if (command == "joined")
                {
                    if (!isVloggerExist)
                    {
                        VloggerStats currentVloggerStats = new VloggerStats(currentVloggerName);
                        vloggers.Add(currentVloggerStats);
                    }
                }
                else if (command == "followed")
                {
                    string currentFollowing = vloggerInfo[2];
                    bool isFollowingExist = vloggers.Exists(v => v.VloggerName == currentFollowing);

                    if (isVloggerExist && isFollowingExist && currentVloggerName != currentFollowing)
                    {
                        bool isFollowerExist = false;
                        VloggerStats currentVlogger = vloggers.Find(v => v.VloggerName == currentFollowing);

                        foreach (var folower in currentVlogger.Followers)
                        {
                            isFollowerExist = currentVlogger.Followers.Exists(f => f == currentVloggerName);
                        }

                        if (!isFollowerExist)
                        {
                            currentVlogger.Followers.Add(currentVloggerName);

                            VloggerStats currentVloggerFollowing = vloggers.Find(v => v.VloggerName == currentVloggerName);
                            currentVloggerFollowing.Followings++;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 0;

            foreach (var vlogger in vloggers.OrderByDescending(v => v.Followers.Count)
                                            .ThenBy(v => v.Followings))
            {
                Console.WriteLine($"{++count}. {vlogger.VloggerName} : {vlogger.Followers.Count} followers, {vlogger.Followings} following");

                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers.OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }

        class VloggerStats
        {
            public VloggerStats(string vloggerName)
            {
                VloggerName = vloggerName;
                Followers = new List<string>();
                Followings = 0;
            }

            public string VloggerName { get; set; }
            public List<string> Followers { get; set; }
            public int Followings { get; set; }
        }
    }
}
