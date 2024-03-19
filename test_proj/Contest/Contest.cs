using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest
{
    static class Contest
    {
        public static void SlyCypher()
        {
            int users = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < users; i++)
            {
                string[] userData = Console.ReadLine().Split(",");
                string fio = userData[0] + userData[1] + userData[2];
                string singleLetters = "";
                for (int j = 0; j < fio.Length; j++)
                {
                    if (singleLetters.Contains(fio[j]))
                    {
                        continue;
                    }
                    singleLetters += fio[j].ToString();
                }
                int countSingleLetters = singleLetters.Length;
                int dateSum = 0;
                string dayMonth = userData[3] + userData[4];
                for (int j = 0; j < dayMonth.Length; j++)
                {
                    dateSum += int.Parse(dayMonth[j].ToString());
                }
                dateSum *= 64;
                int surname = Convert.ToChar(userData[0][0].ToString().ToLower()) - 96;
                surname *= 256;
                int temp = countSingleLetters + dateSum + surname;
                string hex = Convert.ToString(temp, 16).ToUpper();
                if (hex.Length >= 3)
                {
                    result += hex[hex.Length - 3].ToString() + hex[hex.Length - 2].ToString() + hex[hex.Length - 1].ToString() + " ";
                }
                else
                {
                    result += string.Join("", Enumerable.Repeat("0", 3 - hex.Length)) + hex + " ";
                }
            }
            Console.WriteLine(result);
        }

        public static void Client()
        {
            int ridesAmount = int.Parse(Console.ReadLine());
            Dictionary<int, int> rocketsNrides = new();
            for (int i = 0; i < ridesAmount; i++)
            {
                string rideData = Console.ReadLine();
                List<string> arrayRideData = rideData.Split(" ").ToList();
                if (!arrayRideData.ElementAt(4).Equals("B"))
                {
                    if (!rocketsNrides.ContainsKey(int.Parse(arrayRideData[3])))
                    {
                        if (arrayRideData[4].Equals("S") || arrayRideData[4].Equals("C"))
                        {
                            rocketsNrides.Add(int.Parse(arrayRideData[3]), 0);
                            rocketsNrides[int.Parse(arrayRideData[3])] += (int.Parse(arrayRideData[0]) * 24 * 60) + (int.Parse(arrayRideData[1]) * 60) + int.Parse(arrayRideData[2]);
                        }
                        else
                        {
                            rocketsNrides.Add(int.Parse(arrayRideData[3]), 0);
                            rocketsNrides[int.Parse(arrayRideData[3])] -= (int.Parse(arrayRideData[0]) * 24 * 60) + (int.Parse(arrayRideData[1]) * 60) + int.Parse(arrayRideData[2]);
                        }
                        
                    }
                    else
                    {
                        if (arrayRideData[4].Equals("S") || arrayRideData[4].Equals("C"))
                        {
                            rocketsNrides[int.Parse(arrayRideData[3])] += (int.Parse(arrayRideData[0]) * 24 * 60) + (int.Parse(arrayRideData[1]) * 60) + int.Parse(arrayRideData[2]);
                        }
                        else
                        {
                            rocketsNrides[int.Parse(arrayRideData[3])] -= (int.Parse(arrayRideData[0]) * 24 * 60) + (int.Parse(arrayRideData[1]) * 60) + int.Parse(arrayRideData[2]);
                        }
                    }
                }
            }
            List<int> list = rocketsNrides.Select(o => o.Key).OrderBy(o => o).ToList();
            foreach (var item in list)
            {
                Console.Write(rocketsNrides[item] + " ");
            }
        }

        public static void Water()
        {
            int ordersAmount = int.Parse(Console.ReadLine());
            int[,] orders = new int[ordersAmount, 3];
            for (int i = 0; i < ordersAmount; i++)
            {
                var l = Console.ReadLine().Split(" ").ToList();
                orders[i, 0] = int.Parse(l[0]);
                orders[i, 1] = int.Parse(l[1]);
                orders[i, 2] = int.Parse(l[2]);
            }
            int filtersAmount = int.Parse(Console.ReadLine());
            int[,] filters = new int[filtersAmount, 3];
            string result = "";
            for (int i = 0; i < filtersAmount; i++)
            {
                var l = Console.ReadLine().Split(" ");
                filters[i, 0] = int.Parse(l[0]);
                filters[i, 1] = int.Parse(l[1]);
                filters[i, 2] = int.Parse(l[2]);
                int tmp = 0;
                if (filters[i, 2] == 1)
                {
                    for (int j = 0; j < ordersAmount; j++)
                    {
                        if (orders[j, 0] >= filters[i, 0] && orders[j, 0] <= filters[i, 1])
                        {
                            tmp += orders[j, 2];
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < ordersAmount; j++)
                    {
                        if (orders[j, 1] >= filters[i, 0] && orders[j, 1] <= filters[i, 1])
                        {
                            tmp += orders[j, 1] - orders[j, 0];
                        }
                    }
                }
                result += tmp + " ";
            }
            Console.WriteLine(result);
        }
    }
}
