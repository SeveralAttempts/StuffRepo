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

        public static void ToClient()
        {
            int ridesAmount = int.Parse(Console.ReadLine());
            string result = "";
            Dictionary<string, List<List<string>>> rocketsNrides = new();
            List<string> ids = new();
            for (int i = 0; i < ridesAmount; i++)
            {
                List<string> rideData = Console.ReadLine().Split(" ").ToList();
                if (!rocketsNrides.ContainsKey(rideData.ElementAt(3)))
                {
                    rocketsNrides.Add(rideData.ElementAt(3), new List<List<string>>());
                    rocketsNrides[rideData.ElementAt(3)].Add(rideData);
                    ids.Add(rideData.ElementAt(3));
                }
                else
                {
                    rocketsNrides[rideData.ElementAt(3)].Add(rideData);
                }
            }
            for (int i = 0; i < ids.Count; i++)
            {
                foreach (var item in rocketsNrides[ids.ElementAt(i)])
                {
                    if (item.ElementAt(0).Length < 2)
                    {
                        item[0] = "0" + item[0];
                    }
                    if (item.ElementAt(1).Length < 2)
                    {
                        item[1] = "0" + item[1];
                    }
                    if (item.ElementAt(2).Length < 2)
                    {
                        item[2] = "0" + item[2];
                    }
                }
            }
            for (int i = 0; i < ids.Count; i++)
            {
                var a = rocketsNrides[ids.ElementAt(i)].OrderBy(o => int.Parse(o.ElementAt(0) + o.ElementAt(1) + o.ElementAt(2)))
                    .Select(o => o).ToList();
                foreach (var item in a)
                {
                    Console.WriteLine(item[0] + item[1] + item[2] + item[4]);
                }
                rocketsNrides.Remove(ids.ElementAt(i));
                rocketsNrides.Add(ids.ElementAt(i), a);
                Console.WriteLine();
            }
            
        }
    }
}
