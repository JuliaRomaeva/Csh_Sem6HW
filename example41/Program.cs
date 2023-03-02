// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите массив через пробел: ");
string arr = Console.ReadLine();
int[] array = GetArrayFromString(arr);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int CountPositiveNumbers(int[] newArray)
{
    int count = 0;
    foreach (var el in newArray)
    {
        if (el > 0) count++;
    }
    return count;
}
Console.Write($"{String.Join(", ", array)} -> {CountPositiveNumbers(array)}");