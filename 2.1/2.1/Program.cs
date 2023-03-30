/*using System;  //1

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 1 - ый массив (драгоценности): ");
        string jewelry = Console.ReadLine();
        Console.WriteLine("Введите 2 - ый массив (камни): ");
        string stones = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < jewelry.Length; i++)
        {
            for (int j = 0; j < stones.Length; j++)
            {
                if (jewelry[i] == stones[j])
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"{count}");
    }
}*/



/*using System;     // 3


namespace Practica
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[5];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}" + " | ");
            }
            Console.WriteLine(Checkbool(nums));
        }

        static bool Checkbool(int[] nums)
        {
            bool check = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}*/
