using System;

/*
INPUT:
4 5
10101
11100
11010
00101
OUTPUT:
5
2

*/
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// ACM ICPC Team
    /// https://www.hackerrank.com/challenges/acm-icpc-team?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class AcmIcpcTeam
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]);
            int m = Convert.ToInt32(tokens[1]);
            string[] topics = new string[n];
            for (int i = 0; i < n; i++)
            {
                topics[i] = Console.ReadLine();
            }

            Tuple<int, int> maximums = GetMaximums(topics);
            Console.WriteLine($"{maximums.Item1}\n{maximums.Item2}");
        }

        private static Tuple<int, int> GetMaximums(string[] topics)
        {
            int maximumTopics = GetMaximumTopics(topics);
            int maximumTeams = GetMaximumTeams(topics, maximumTopics);

            return Tuple.Create(maximumTopics, maximumTeams);
        }

        private static int GetMaximumTopics(string[] topics)
        {
            int maximum = 0;
            
            for (int i = 0; i < topics.Length - 2; i++)
            {
                var topic = topics[i];

                for (int j = 1; j < topic.Length - 1; j++)
                {
                    int currMaximum = 0;
                    var nextTopic = topics[j];
                    for (int k = 0; k < topic.Length; k++)
                    {
                        int left = int.Parse(topic[k].ToString());
                        int right = int.Parse(nextTopic[k].ToString());
                        if ((left | right) == 1)
                            currMaximum++;
                    }

                    if (currMaximum > maximum)
                        maximum = currMaximum;
                }

            }

            return maximum;
        }

        private static int GetMaximumTeams(string[] topics, int maximumTopics)
        {
            int count = 0;
            for (int i = 0; i < topics.Length - 2; i++)
            {
                var topic = topics[i];

                for (int j = 1; j < topic.Length - 1; j++)
                {
                    var nextTopic = topics[i + 1];
                    int currMaximum = 0;
                    for (int k = 0; k < topic.Length; k++)
                    {
                        if (topic[k] == nextTopic[k] && topic[k] == 1)
                            currMaximum++;
                    }

                    if (currMaximum == maximumTopics)
                        count++;
                }
            }

            return count;
        }
    }
}
