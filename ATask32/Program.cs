int[] nums = {345, 897, 568, 234};
int evensCount = nums.Count(n => n % 2 == 0);
Console.WriteLine("Количество четных чисел " + evensCount);