namespace _01._Trojan_Invasion
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Trojan
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int warrior = 0;
            int plate = 0;

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            
            Stack<int> warriors = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {                
                warriors = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }
                while (warriors.Count > 0 || plates.Count == 0)
                {
                    if (warrior <= 0)
                    {
                        
                        warrior = warriors.Pop();
                    }
                    if (plate <= 0)
                    {
                        if (plates.Count == 0)
                        {
                            break;
                        }
                        plate = plates.Dequeue();
                    }
                    int tempWar = warrior;
                    warrior -= plate;
                    plate -= tempWar;
                }
            }

            if (plates.Count == 0)
            {
                List<int> left = warriors.ToList();
                if (warrior > 0)
                {                    
                    left.Add(warrior);
                    left.Reverse();
                }

                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine("Warriors left: " + string.Join(", ", left));
            }
            else
            {
                List<int> left = plates.ToList();
                if (plate > 0)
                {
                    left.Reverse();
                    left.Add(plate);
                    left.Reverse();
                }

                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine("Plates left: " + string.Join(", ", plates));
            }
        }
    }
}
