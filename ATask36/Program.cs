// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int result = 0;
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите числа: ");
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
               mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (mass[i] % 2 != 1)
                {
                    result += mass[i];
                }
            }
            Console.WriteLine($"Сумма нечетных эл.массива составляет {result}");

// Я не сделал эту задачу